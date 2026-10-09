namespace CinemaBooking.Domain;
public sealed class RegularPricingStrategy : ITicketPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice)
    {
        if (basePrice <= 0) throw new ArgumentOutOfRangeException(nameof(basePrice), "Ціна має бути більшою за нуль.");
        return basePrice;
    }
}
