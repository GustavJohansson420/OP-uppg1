class Program 
{
    static void Main()
    {
        Console.WriteLine("Skriv in hur lång tid Tor ska äta moroten på:");
        int TorTid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Skriv in hur lång tid Mor ska äta moroten på:");
        int MorTid = Convert.ToInt32(Console.ReadLine());
        double num2 = TorTid + MorTid;
        double num3 = 40/num2;
        double TorMorot = num3*MorTid;
        double MorMorot = num3*TorTid;
        Console.WriteLine("Tor äter " + Convert.ToInt32(Math.Floor(TorMorot)) + " stycken morötter");
        Console.WriteLine("Mor äter " + Convert.ToInt32(Math.Floor(MorMorot)) + " stycken morötter");
    }
}
