namespace RentCars.Models;

public class PhysicalPerson : Person
{
    public string? CPF { get; set; }

    public override double CalculatePrice(double pricePerDay, int daysRented)
    {
        double total = pricePerDay * daysRented;
        return total;
    }
}