using System;

namespace _5
{
    
    class Program
    {
        const double MODEL_100_PRICE = 1999.99;
        const double MODEL_200_PRICE = 2699.99;
        const double MODEL_300_PRICE = 3499.99;

        const int MODEL_100_SIZE = 24;
        const int MODEL_200_SIZE = 27;
        const int MODEL_300_SIZE = 32;
        static void Main(string[] args)
        {
            Console.WriteLine("Która telewizor Ci się podba?");
            Console.WriteLine("Model 100, 200 czy 300?");
            string modeluNumber = Console.ReadLine();

            switch (modeluNumber)
            {
                case "100":
                    Console.WriteLine("Cenna: " + MODEL_100_PRICE + " zł");
                    Console.WriteLine("Przekątna: " + MODEL_100_SIZE);    
                    break;
                case "200":
                    Console.WriteLine("Cenna: " + MODEL_200_PRICE + " zł");
                    Console.WriteLine("Przekątna: " + MODEL_200_SIZE);
                    break;
                case "300":
                    Console.WriteLine("Cenna: " +MODEL_300_PRICE + " zł");
                    Console.WriteLine("Przekątna: " + MODEL_300_SIZE);
                    break;
                default:
                    Console.WriteLine("Błędny model telewizora.");
                    break;

            }
        }
    }
}
