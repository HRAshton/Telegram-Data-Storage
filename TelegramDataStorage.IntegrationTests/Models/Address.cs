namespace TelegramDataStorage.IntegrationTests.Models;

public class Address
{
    public string Street { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public string? Country { get; set; }
}