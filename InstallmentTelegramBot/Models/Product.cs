using System.Text.Json.Serialization;

namespace InstallmentTelegramBot.Models
{
    public class Product
    {
        [JsonPropertyName("memory")]
        public int Memory { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("document")]
        public bool Document { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("defect")]
        public bool Defect { get; set; }
    }
}