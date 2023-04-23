using System.Diagnostics;
using Tinify;
using TinyGUI.Data;
using TinyGUI.Events;
using TinyGUI.Handlers;
using TinyGUI.Utils;

namespace TinyGUI.Systems
{
    public class TinyCompression
    {
        private List<string> filesPaths = new();

        public event CompressingAPIDoneHandler? APIDone;
        public event CompressingAPIUpdateHandler? APIUpdate;
        public event CompressingEndedHandler? LoadingEnded;

        public void UpdateList(List<string> filesPaths) 
        { 
            this.filesPaths = new List<string>(filesPaths); 
        }

        internal async Task CompressAsync(TinySettings settings, TinyStatistics statistics, List<APIKey> apiKeys)
        {
            if (apiKeys.Count == 0 || filesPaths.Count == 0)
            {
                LoadingEnded?.Invoke(this, new CompressingEndedEventArgs(apiKeys, filesPaths, new List<string>(), TimeSpan.Zero));
                return;
            }

            Dictionary<APIKey, List<string>> listPerAPI = ListUtils.SplitFiles(filesPaths, apiKeys, settings);
            List<string> optimizedPaths = new();

            Stopwatch watch = Stopwatch.StartNew();

            var semaphore = new SemaphoreSlim(settings.CompressingThreads == 0 ? int.MaxValue : settings.CompressingThreads);
            var tasks = new List<Task>();
            var lockObject = new object();

            foreach (var list in listPerAPI)
            {
                APIKey apiKey = list.Key;
                tasks.Add(Task.Run(async () =>
                {
                    await semaphore.WaitAsync().ConfigureAwait(false);

                    Stopwatch apiWatch = Stopwatch.StartNew();
                    using (TinifyClient client = new(apiKey.Key))
                    {
                        foreach (var path in list.Value)
                        {
                            Stopwatch fileWatch = Stopwatch.StartNew();
                            try
                            {
                                if (Path.GetDirectoryName(path) is not string folder) continue;
                                string name = Path.GetFileNameWithoutExtension(path);
                                string ext = Path.GetExtension(path);

                                // Check Folder
                                string optimizedFolder = Path.Combine(folder, settings.CompressedPath);
                                if (!Directory.Exists(optimizedFolder))
                                {
                                    Directory.CreateDirectory(optimizedFolder);
                                }

                                // Optimize
                                await using var optimizedImage = await client.ShrinkFromFileAsync(path).ConfigureAwait(false);

                                // Create File Name
                                var fileName = settings.CompressedName;
                                fileName = fileName.Replace("{name}", $"{name}");
                                
                                // Save File
                                var optimizedFile = Path.Combine(optimizedFolder, $"{fileName}{ext}");
                                await optimizedImage.ToFileAsync(optimizedFile).ConfigureAwait(false);

                                // Save to lists
                                lock (lockObject)
                                {
                                    optimizedPaths.Add(optimizedFile);
                                    apiKey.CompressionsCount++;
                                    statistics.CompressedImages++;

                                    fileWatch.Stop();
                                    APIUpdate?.Invoke(this, new CompressingAPIUpdateEventArgs(apiKey,
                                        path, optimizedFile,
                                        filesPaths, optimizedPaths,
                                        fileWatch.Elapsed, watch.Elapsed));
                                }
                            }
                            catch (Exception ex)
                            {
                                fileWatch.Stop();
                                Console.WriteLine(ex.ToString()); //TODO: Add Exceptions
                            }
                        }
                    }
                    semaphore.Release();
                    apiWatch.Stop();

                    APIDone?.Invoke(this, new CompressingAPIDoneEventArgs(apiKey, 
                        filesPaths, optimizedPaths, 
                        apiWatch.Elapsed, watch.Elapsed));
                }));
            }
            await Task.WhenAll(tasks).ConfigureAwait(false);
            watch.Stop();

            LoadingEnded?.Invoke(this, new CompressingEndedEventArgs(apiKeys, 
                filesPaths, optimizedPaths, 
                watch.Elapsed));
        }
    }
}