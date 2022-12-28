using System;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double fee = calculateFee();
            Console.WriteLine($"Fee is {fee}\n");
            Console.WriteLine($"Fee is {calculateFee()}\n");
            Console.WriteLine($"Fee is {calculateFee(650.0)}\n");
            Console.WriteLine($"Fee is {calculateFee(500.0,3)}\n");


        }
        private double calculateFee(double dailyRate=500.0,int noOfDays = 1)
        {
            Console.WriteLine("calculateFee using two optional parameters");
            return dailyRate * noOfDays;
        }
        private double calculateFee(double dailyRate = 600.0)
        {
            Console.WriteLine("calculateFee using one optional parameters");
            int defaultOfDays = 1;
            return dailyRate * defaultOfDays;
        }
        private double calculateFee()
        {
            Console.WriteLine("calculateFee using hardcoded values");
            double defaultDailyRate = 400.0;
            int defaultOfDays = 1;
            return defaultDailyRate * defaultOfDays;
        }
    }
}
