using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OmoriDialogueParser.Model.Data
{
    class MapEntry
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("expanded")]
        public bool Expanded { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("order")]
        public int Order { get; set; } 

        [JsonPropertyName("parentId")]
        public int ParentId { get; set; } 

        [JsonPropertyName("scrollX")]
        public double ScrollX { get; set; } 

        [JsonPropertyName("scrollY")]
        public double ScrollY { get; set; } 

        [JsonPropertyName("type")]
        public string Type { get; set; } 

        [JsonPropertyName("line")]
        public object Line { get; set; } 
    }
}
