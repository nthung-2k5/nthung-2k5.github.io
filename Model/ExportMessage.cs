using System.Text.Json.Serialization;

namespace OmoriDialogueParser.Model
{
    public class ExportMessage
    {
        public ExportMessage() { }
        [JsonPropertyName("s")] public string? Speaker { get; set; }
        [JsonPropertyName("h")] public string Html { get; set; }

        [JsonPropertyName("b")] public int? Background { get; set; }
        [JsonPropertyName("fs")] public string? FaceSet { get; set; }
        [JsonPropertyName("fi")] public int? FaceIndex { get; set; }
    }
}
