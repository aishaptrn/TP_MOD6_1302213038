// See https://aka.ms/new-console-template for more information

using TP_MOD6_1302213038;

class main
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test SayaTubeVideo");
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial " +
            "Design by Contract - Aisha Putri Nuryan");
        vid.increasePlayCount(1864);
        vid.printVideoDetails();

        Console.WriteLine("\nTest Design-by-Contract");
        SayaTubeVideo vidA = new SayaTubeVideo("Praktikum Modul 6");
        vidA = new SayaTubeVideo(null);
        vidA.increasePlayCount(-1865);
        vidA.printVideoDetails();
    }
}