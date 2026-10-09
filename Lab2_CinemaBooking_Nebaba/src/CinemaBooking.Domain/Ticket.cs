namespace CinemaBooking.Domain;
public sealed class Ticket
{
    public int SeatNumber { get; }
    public decimal Price { get; }
    public bool IsCancelled { get; private set; }
    public Ticket(int seatNumber, decimal price)
    {
        if (seatNumber <= 0) throw new ArgumentOutOfRangeException(nameof(seatNumber));
        if (price <= 0) throw new ArgumentOutOfRangeException(nameof(price));
        SeatNumber = seatNumber; Price = price;
    }
    internal void Cancel() => IsCancelled = true;
}
