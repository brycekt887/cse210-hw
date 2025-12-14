using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("100 Center St", "Rexburg", "ID", "USA");

        Event lecture = new Lecture(
            "Tech Talk",
            "A talk about software careers",
            "Nov 20",
            "6:00 PM",
            address,
            "Jane Smith",
            150
        );

        Event reception = new Reception(
            "Networking Night",
            "Meet and greet event",
            "Nov 22",
            "7:00 PM",
            address,
            "events@company.com"
        );

        Event outdoor = new OutdoorGathering(
            "Fall Festival",
            "Outdoor food and games",
            "Nov 25",
            "4:00 PM",
            address,
            "Cool and clear"
        );

        Event[] events = { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.FullDetails());
            Console.WriteLine();
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine("\n----------------------\n");
        }
    }
}
