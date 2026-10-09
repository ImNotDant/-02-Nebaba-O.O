namespace CinemaBooking.Domain;
public sealed class Hall
{
    public string Name { get; }
    public int SeatCount { get; }
    public Hall(string name, int seatCount)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Назва залу обов'язкова.");
        if (seatCount <= 0) throw new ArgumentOutOfRangeException(nameof(seatCount));
        Name = name; SeatCount = seatCount;
    }
}
