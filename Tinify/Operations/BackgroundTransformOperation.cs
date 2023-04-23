using System.Text.Json.Serialization;

namespace Tinify.Operations
{
    public sealed record BackgroundTransformOperation([property: JsonPropertyName("background")] string BackgroundColor);
}