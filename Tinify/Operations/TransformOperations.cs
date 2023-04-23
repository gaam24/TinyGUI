using System.Text.Json.Serialization;

namespace Tinify.Operations
{
    public record TransformOperations
    {
        [JsonPropertyName("transform")] public BackgroundTransformOperation? Background { get; }

        [JsonPropertyName("convert")] public ConvertOperation? Convert { get; }

        [JsonPropertyName("preserve")] public string[]? Preserve { get; }

        [JsonPropertyName("resize")] public ResizeOperation? Resize { get; }

        public TransformOperations(
            ResizeOperation? resize = null,
            ConvertOperation? convert = null,
            PreserveOperation? preserve = null)
        {
            if (resize is null && convert is null && preserve is null)
            {
                throw new ArgumentException("At least one transform operation must be specified");
            }

            Convert = convert;
            Background = convert?.BackgroundTransform;
            Preserve = preserve?.Options;
            Resize = resize;
        }
    }
}