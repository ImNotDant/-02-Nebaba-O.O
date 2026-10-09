namespace CinemaBooking.Domain;
public sealed class Movie
{
    public string Title { get; }
    public int DurationMinutes { get; }
    public Movie(string title, int durationMinutes)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Назва фільму обов'язкова.");
        if (durationMinutes <= 0) throw new ArgumentOutOfRangeException(nameof(durationMinutes));
        Title = title; DurationMinutes = durationMinutes;
    }
}
