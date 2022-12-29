using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace InstallmentTelegramBot.Models.Base;

public class BaseModel
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [Required]
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
