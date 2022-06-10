using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            takeChoose();
        }
        public static void takeChoose()
        {
            Console.Write("Temperature Converter. Select Fahrenheit (press F) or Celsius (press C): ");
            int i = 0;
            while (i < 10)
            {

                char userChoice = Convert.ToChar(Console.ReadLine().ToUpper());
                if (userChoice == 'F')
                {
                    Console.WriteLine("Enter temperature in Fahrenheit");
                    int far = Convert.ToInt32(Console.ReadLine());
                    int CelSum = (far - 32) * 5 / 9;
                    Console.WriteLine($"Temperature {CelSum} C");
                }
                else if (userChoice == 'C')
                {
                    Console.WriteLine("Enter temperature in Celsius");
                    int cel = Convert.ToInt32(Console.ReadLine());
                    int FarSum = (cel * 9 / 5) + 32;
                    Console.WriteLine($"Temperature {FarSum} F");
                }
                else
                {
                    i++;
                    Console.WriteLine($"Check the input character and try again");
                }
            }
        }
    }
}
