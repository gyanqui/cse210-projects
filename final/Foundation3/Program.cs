using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Avenida de la Universidad", "Lima", "Lima", "Peru");

        Lecture lecture = new Lecture("Literary Reading: 'A Perfect Short Story'", "An evening of literary exploration with Valeria Alcala", "November 29, 2023", "9 AM", address, "Valeria Alcala", 120);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("Izaguirre", "Los Olivos", "Lima", "Peru");

        Reception reception = new Reception("Devotional for Young Single Adults", "Face to face with Elder Quentin L. Cook for YSA", "August 18, 2023", "9 PM", addressR, "devotional@youngadult.com");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("Plaza de Armas", "Cusco", "Cusco", "Peru");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Festival Inti Raymi", "The Celebration of the Sun", "September 16, 2023", "9 PM", addressOG, "sunny");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}