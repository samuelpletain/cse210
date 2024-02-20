using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Chicago", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Av. des Champs Elysees", "Paris", "Ile-de-France", "France");

        Lecture lecture = new Lecture("The History of the Internet", "A comprehensive overview of the history of the internet", "2022-01-15", "18:00", address1, "John Doe", 100);
        Reception reception = new Reception("New Year's Eve Party", "A celebration of the new year", "2021-12-31", "20:00", address2, "newyears2022@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Park", "A fun day in the sun", "2022-07-04", "12:00", address3, "sunny");

        List<Event> events = new List<Event>
        {
            lecture,
            reception,
            outdoorGathering
        };

        foreach (Event e in events)
        {
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetShortDescription());
            if (e != events[events.Count - 1])
            {
            Console.WriteLine();
            Console.WriteLine("=====================================");
            }
        }
    }
}