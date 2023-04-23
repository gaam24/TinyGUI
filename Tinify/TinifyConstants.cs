using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tinify
{
    internal static class TinifyConstants
    {
        internal static readonly JsonSerializerOptions SerializerOptions = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };
    }
}