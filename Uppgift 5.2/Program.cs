using System;
 namespace uppgift5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            tal[0] = 2;
            tal[1] = 3;
            Console.WriteLine("Skriv in ditt tal till arrayen");
            tal[2] = int.Parse(Console.ReadLine());
            Console.WriteLine(tal[0] + " " + tal[1] + " " + tal[2]);
        }
    }
}