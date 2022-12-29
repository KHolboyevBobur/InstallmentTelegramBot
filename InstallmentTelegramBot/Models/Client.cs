using InstallmentTelegramBot.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace InstallmentTelegramBot.Models;

public class Client : BaseModel
{
    [Required]
    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }

    [Required]
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }

    [Required]
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [Required]
    [JsonPropertyName("productName")]
    public Product? ProductName { get; set; }

    [Required]
    [JsonPropertyName("purchaseDate")]
    public DateTime PurchaseDate { get; set; }      //дата покупки

    [Required]
    [JsonPropertyName("installmentDate")]
    public DateTime InstallmentDate { get; set; }  // дата рассрочки
    
    [Required]
    [JsonPropertyName("salary")]
    public DateTime Salary { get; set; }          //  ежемесячная плата

}
