// See https://aka.ms/new-console-template for more information

using TP_MOD6_1302213038;

class main
{
    static void Main(string[] args)
    {
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial " +
            "Design by Contract - Aisha Putri Nuryan");
        vid.increasePlayCount(1864);
        vid.printVideoDetails();
    }
}