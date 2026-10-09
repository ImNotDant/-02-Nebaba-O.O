using CinemaBooking.Domain;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Лабораторна робота №2 — ООП");
Console.WriteLine("Студент: Небаба О.О. | Група: 401ТК | Варіант: 4 — Кінотеатр");
var movie = new Movie("Інтерстеллар", 169);
var hall = new Hall("Зал №1", 60);
var screening = new Screening(movie, hall);
ITicketPricingStrategy regular = new RegularPricingStrategy();
ITicketPricingStrategy student = new StudentPricingStrategy();
var t1 = screening.ReserveSeat(10, 200m, regular);
var t2 = screening.ReserveSeat(11, 200m, student);
Console.WriteLine($"Фільм: {screening.Movie.Title}, тривалість: {movie.DurationMinutes} хв.");
Console.WriteLine($"Зал: {hall.Name}; місць: {hall.SeatCount}");
Console.WriteLine($"Звичайний квиток (місце {t1.SeatNumber}): {t1.Price:F2} грн");
Console.WriteLine($"Студентський квиток (місце {t2.SeatNumber}): {t2.Price:F2} грн");
Console.WriteLine($"Бронювань: {screening.Tickets.Count}");
screening.Start();
try { screening.CancelReservation(10); }
catch (InvalidOperationException ex) { Console.WriteLine($"Перевірка правила: {ex.Message}"); }
screening.Finish();
Console.WriteLine($"Статус сеансу: {screening.Status}");
