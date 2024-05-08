namespace RentCars.Models;

public class LegalPerson : Person
{
    public string? SocialReason { get; set; }
    public string? CNPJ { get; set; }

    public override double CalculatePrice(double pricePerDay, int daysRented)
    {
        double discount = 0.9;
        double totalWithoutDiscount = pricePerDay * daysRented;
        return totalWithoutDiscount * discount;
    }
}