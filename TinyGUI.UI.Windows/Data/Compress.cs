using System.Timers;
using TinyGUI.UI.Windows.Events;
using TinyGUI.UI.Windows.Handlers;
using TinyGUI.UI.Windows.Utils;
using Timer = System.Timers.Timer;

namespace TinyGUI.UI.Windows.Data
{
    internal sealed class Compress : IDisposable
    {
        private TimeSpan _eta = TimeSpan.Zero;
        public TimeSpan ETA { get => _eta; }

        private string _percent = string.Empty;
        public string Percent { get => _percent; }

        public event CompressTickHandler? CompressTick;

        private Timer? etaTimer;
        private DateTime? etaStart;

        public Compress()
        {
            UpdateProgress(TimeSpan.Zero);
        }

        public void Start()
        {
            // Start time
            etaStart = DateTime.Now;

            // Start Timer
            etaTimer = new Timer(1000);
            etaTimer.Elapsed += OnTimedEvent;
            etaTimer.Start();
        }

        public void Dispose()
        {
            etaTimer?.Stop();
            etaTimer?.Dispose();
        }

        public void UpdateProgress(TimeSpan elapsed, int current = 0, int max = 0)
        {
            _eta = elapsed == TimeSpan.Zero ? elapsed : TimeUtils.GetETA(elapsed, current, max);
            _percent = StringUtils.GetPercentage(current, max);
        }

        private void OnTimedEvent(object? source, ElapsedEventArgs e)
        {
            if (etaStart != null)
            {
                var time = TimeSpan.FromTicks(e.SignalTime.Ticks - etaStart.Value.Ticks);
                if (time.Ticks >= _eta.Ticks)
                {
                    _eta = time;
                }
                CompressTick?.Invoke(this, new CompressTickEventArgs(time));
            }
        }
    }
}
