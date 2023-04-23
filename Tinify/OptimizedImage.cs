using System.Text.Json;
using Tinify.Operations;

namespace Tinify
{
    public sealed class OptimizedImage : IDisposable, IAsyncDisposable
    {
        public int? ImageSize { get; private init; }

        public string? ImageType { get; private init; }

        public Uri? Location { get; private init; }

        private TinifyClient _client = null!;

        private bool _disposed;

        private ImageResult? _result;

        private OptimizedImage()
        {
        }

        public async Task CopyToBufferAsync(Memory<byte> buffer)
        {
            var result = await GetResultAsync();
            result.CopyToBuffer(buffer.Span);
        }

        public void Dispose() => DisposeCore();

        public async ValueTask DisposeAsync() => await Task.Run(DisposeCore).ConfigureAwait(false);

        public async Task<byte[]> ToBufferAsync()
        {
            var result = await GetResultAsync();
            return result.ToBuffer();
        }

        public async Task ToFileAsync(string fileName)
        {
            var result = await GetResultAsync();
            await result.ToFileAsync(fileName).ConfigureAwait(false);
        }

        public async Task ToStreamAsync(Stream stream)
        {
            var result = await GetResultAsync();
            await result.ToStreamAsync(stream).ConfigureAwait(false);
        }

        public async Task<ImageResult> TransformImageAsync(TransformOperations operations) => await _client.GetResultAsync(this, operations).ConfigureAwait(false);

        private void DisposeCore()
        {
            _disposed = true;
            if (_result is null) return;

            _result.Dispose();
            _result = null;
        }

        private static async Task<(string? imageType, int? imageSize)> GetImageDataFromResponseAsync(HttpResponseMessage? response)
        {
            if (response == null) return (null, null);
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (string.IsNullOrWhiteSpace(body)) return (null, null);

            int? imageSize = null;
            string? imageType = null;
            using var document = JsonDocument.Parse(body);
            if (document.RootElement.TryGetProperty("output", out var output))
            {
                if (output.TryGetProperty("size", out var size))
                {
                    imageSize = size.GetInt32();
                }

                if (output.TryGetProperty("type", out var imgType))
                {
                    imageType = imgType.GetString();
                }
            }

            return (imageType, imageSize);
        }

        private async ValueTask<ImageResult> GetResultAsync()
        {
            if (_disposed) throw new ObjectDisposedException(nameof(OptimizedImage));
            if (_result is not null) return _result;

            _result = await _client.GetResultAsync(this).ConfigureAwait(false);
            return _result;
        }

        internal static async Task<OptimizedImage> CreateAsync(HttpResponseMessage? response, TinifyClient client, bool disposeResponse)
        {
            try
            {
                var (imageType, imageSize) = await GetImageDataFromResponseAsync(response).ConfigureAwait(false);
                return new OptimizedImage
                {
                    _client = client,
                    Location = response?.Headers.Location,
                    ImageSize = imageSize,
                    ImageType = imageType,
                };
            }
            finally
            {
                if (disposeResponse) response?.Dispose();
            }
        }
    }
}