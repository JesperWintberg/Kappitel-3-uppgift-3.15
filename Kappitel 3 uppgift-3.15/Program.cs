using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra en bil?");
            string tim = Console.ReadLine();

            float tid = float.Parse(tim);

            float tide = (tid * 80);

            if (tide < 950)
            {
                Console.WriteLine("Bilen kommer att kosta dig " + tide);
            }

            else
            {
                Console.WriteLine("Du får tyvärr inte spendera mer en 950kr på din bil");
            }

        }
    }
}

