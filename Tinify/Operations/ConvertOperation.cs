using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Tinify.Enums;

namespace Tinify.Operations
{
    public sealed record ConvertOperation
    {
        [JsonPropertyName("type")]
        public string[] ImageFormats { get; }

        internal BackgroundTransformOperation? BackgroundTransform { get; }

        private ConvertOperation(string[] formats, string? backgroundColor = null)
        {
            ImageFormats = formats;
            BackgroundTransform = !string.IsNullOrEmpty(backgroundColor)
                ? new BackgroundTransformOperation(backgroundColor)
                : null;
        }

        public ConvertOperation(ConvertImageFormat format, Color backgroundColor) : this(
            new[] { ImageFormatToString(format) },
            ToHtmlColor(backgroundColor))
        {
        }

        public ConvertOperation(ConvertImageFormat format, string? backgroundColor = null) : this(
            new[] { ImageFormatToString(format) },
            backgroundColor)
        {
            ImageFormats = new[] { ImageFormatToString(format) };
            BackgroundTransform =
                backgroundColor is not null ? new BackgroundTransformOperation(backgroundColor) : null;
        }

        public ConvertOperation(IEnumerable<ConvertImageFormat> formats, Color backgroundColor) : this(
            ToImageFormatStringArray(formats),
            ToHtmlColor(backgroundColor))
        {
        }

        public ConvertOperation(IEnumerable<ConvertImageFormat> formats, string? backgroundColor = null) : this(
            ToImageFormatStringArray(formats),
            backgroundColor)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string ImageFormatToString(ConvertImageFormat format)
        {
            return format switch
            {
                ConvertImageFormat.Jpeg => "image/jpeg",
                ConvertImageFormat.Png => "image/png",
                ConvertImageFormat.WebP => "image/webp",
                _ => throw new ArgumentException($"Invalid image format specified: {format}", nameof(format))
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string? ToHtmlColor(Color? backgroundColor)
        {
            if (backgroundColor is null)
                return null;

            var bgColor = backgroundColor.Value;
            return $"#" +
                $"{bgColor.R.ToString("X2", null)}" +
                $"{bgColor.G.ToString("X2", null)}" +
                $"{bgColor.B.ToString("X2", null)}";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string[] ToImageFormatStringArray(IEnumerable<ConvertImageFormat> formats)
        { return new HashSet<string>(formats.Select(ImageFormatToString)).ToArray(); }
    }
}