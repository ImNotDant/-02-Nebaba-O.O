namespace CinemaBooking.Domain;
public sealed class StudentPricingStrategy : ITicketPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice)
    {
        if (basePrice <= 0) throw new ArgumentOutOfRangeException(nameof(basePrice), "Ціна має бути більшою за нуль.");
        return decimal.Round(basePrice * 0.80m, 2);
    }
}
