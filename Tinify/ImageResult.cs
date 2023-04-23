using CommunityToolkit.HighPerformance.Buffers;
using System.Net.Http.Headers;
using IMemoryOwnerExtensions = CommunityToolkit.HighPerformance.IMemoryOwnerExtensions;

namespace Tinify
{
    public sealed class ImageResult : IDisposable, IAsyncDisposable
    {
        public string? ContentType { get; private init; }

        public int DataLength => _data!.Length;

        public int? Height { get; private init; }

        public Uri? Location { get; private init; }

        public long? Size { get; private init; }

        public int? Width { get; private init; }

        private MemoryOwner<byte>? _data;

        private ImageResult()
        {
        }

        public void CopyToBuffer(Span<byte> buffer) => _data!.Span.CopyTo(buffer);

        public void Dispose() => DisposeCore();

        public async ValueTask DisposeAsync() => await Task.Run(DisposeCore).ConfigureAwait(false);

        public byte[] ToBuffer() => _data!.Span.ToArray();

        public async Task ToFileAsync(string path)
        {
            await using var fs = File.OpenWrite(path);
            await fs.WriteAsync(_data!.Memory);
        }

        public async Task ToStreamAsync(Stream destination) => await destination.WriteAsync(_data!.Memory).ConfigureAwait(false);

        private void DisposeCore()
        {
            if (_data is null)
                return;

            _data.Dispose();
            _data = null;
        }

        private static async Task<MemoryOwner<byte>> GetDataFromResponseAsync(HttpResponseMessage? response, int? contentLength)
        {
            if (contentLength is null or 0 || response == null)
                return MemoryOwner<byte>.Empty;

            var buffer = MemoryOwner<byte>.Allocate(contentLength.Value);
            await response.Content.CopyToAsync(IMemoryOwnerExtensions.AsStream(buffer)).ConfigureAwait(false);
            return buffer;
        }

        private static int? GetIntValueFromHeader(HttpHeaders? headers, string value)
        {
            if (headers is null)
                return null;
            if (!headers.TryGetValues(value, out var values))
                return null;

            foreach (var header in values)
                if (int.TryParse(header, out var result))
                    return result;

            return null;
        }

        internal static async Task<ImageResult> CreateAsync(HttpResponseMessage? response, bool disposeResponse)
        {
            try
            {
                var header = response?.Headers;
                var content = response?.Content;
                var contentHeaders = content?.Headers;
                var contentLength = (int?)contentHeaders?.ContentLength;

                return new ImageResult()
                {
                    Width = GetIntValueFromHeader(header, "Image-Width"),
                    Height = GetIntValueFromHeader(header, "Image-Height"),
                    Location = header?.Location,
                    ContentType = contentHeaders?.ContentType?.MediaType,
                    Size = contentHeaders?.ContentLength,
                    _data = await GetDataFromResponseAsync(response, contentLength).ConfigureAwait(false),
                };
            }
            finally
            {
                if (disposeResponse)
                    response?.Dispose();
            }
        }
    }
}