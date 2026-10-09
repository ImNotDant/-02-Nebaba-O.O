namespace CinemaBooking.Domain;
public enum ScreeningStatus { Scheduled, Started, Finished }

public sealed class Screening
{
    private readonly List<Ticket> _tickets = [];
    public Movie Movie { get; }
    public Hall Hall { get; }
    public ScreeningStatus Status { get; private set; } = ScreeningStatus.Scheduled;
    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();

    public Screening(Movie movie, Hall hall)
    {
        Movie = movie ?? throw new ArgumentNullException(nameof(movie));
        Hall = hall ?? throw new ArgumentNullException(nameof(hall));
    }

    public Ticket ReserveSeat(int seatNumber, decimal basePrice, ITicketPricingStrategy pricingStrategy)
    {
        if (Status != ScreeningStatus.Scheduled) throw new InvalidOperationException("Бронювання доступне лише до початку сеансу.");
        if (seatNumber < 1 || seatNumber > Hall.SeatCount) throw new ArgumentOutOfRangeException(nameof(seatNumber), "Місця не існує.");
        if (_tickets.Any(t => t.SeatNumber == seatNumber && !t.IsCancelled)) throw new InvalidOperationException("Місце вже заброньоване.");
        ArgumentNullException.ThrowIfNull(pricingStrategy);
        var ticket = new Ticket(seatNumber, pricingStrategy.CalculatePrice(basePrice));
        _tickets.Add(ticket);
        return ticket;
    }

    public void CancelReservation(int seatNumber)
    {
        if (Status != ScreeningStatus.Scheduled) throw new InvalidOperationException("Після початку сеансу квитки не повертаються.");
        var ticket = _tickets.SingleOrDefault(t => t.SeatNumber == seatNumber && !t.IsCancelled);
        if (ticket is null) throw new InvalidOperationException("Активне бронювання не знайдено.");
        ticket.Cancel();
    }

    public void Start()
    {
        if (Status != ScreeningStatus.Scheduled) throw new InvalidOperationException("Можна розпочати лише запланований сеанс.");
        Status = ScreeningStatus.Started;
    }
    public void Finish()
    {
        if (Status != ScreeningStatus.Started) throw new InvalidOperationException("Спочатку потрібно розпочати сеанс.");
        Status = ScreeningStatus.Finished;
    }
}
