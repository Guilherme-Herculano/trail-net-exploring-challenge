namespace HostingProjectChallenge.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuests(List<Person> guests)
        {
            if (guests.Count < Suite.Capacity)
            {
                Guests = guests;
            }
            else
            {
                throw new ArgumentException("The number of guests must not exceed the capacity of the suite");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetNumberOfGuests() => Guests.Count;

        public decimal CalculateDailyRate()
        {
            decimal value = ReservedDays * Suite.DailyRate;

            if (ReservedDays >= 10)
            {
                value -= value / 10;
            }

            return value;
        }


    }
}
