using System;

namespace Demo_Dice
{
    class Dice
    {
        private int sides;
        public int Sides
        {
            get
            {
                return sides;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Sides must be positive number");
                else
                    sides = value;
            }
        }
        public string Type { get; set; }
        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, sides + 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dice DeciD6 = new Dice();
            Dice DeciD8 = new Dice();

            Console.WriteLine("Enter sides:");
            DeciD6.Sides = int.Parse(Console.ReadLine());
            Console.WriteLine("Side is {0}", DeciD6.Sides);
            Console.WriteLine("Sides is  returned {0}", DeciD6.Roll());
            Console.ReadLine();
        }
    }
}
