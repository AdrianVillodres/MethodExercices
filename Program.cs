namespace MethodExercicesFirstBattery
{
    public class Program
    {
        public static void Main()
        {
            const string HoursParkedMsg = "How many hours have you been parked?";
            const string MinutesParkedMsg = "How many minutes have you been parked?";
            const string ErrorMsg = "Error, you must put an integer number (> 0)";

            int hours = 0;
            int minutes = 0;
            bool hoursValid = false;
            bool minutesValid = false;


            while (!hoursValid)
            {
                Console.WriteLine(HoursParkedMsg);
                try
                {
                    hours = Int32.Parse(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine(ErrorMsg);
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorMsg);
                }
                catch (Exception)
                {
                    Console.WriteLine(ErrorMsg);
                }
                if (hours >= 0f)
                {
                    hoursValid = true;
                }
                else
                {
                    Console.WriteLine(ErrorMsg);
                }
            }
            while (!minutesValid)
            {
                Console.WriteLine(MinutesParkedMsg);
                try
                {
                    minutes = Int32.Parse(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine(ErrorMsg);
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorMsg);
                }
                catch (Exception)
                {
                    Console.WriteLine(ErrorMsg);
                }
                if (minutes >= 0f)
                {
                    minutesValid = true;
                }
                else
                {
                    Console.WriteLine(ErrorMsg);
                }

                if (hoursValid && minutesValid)
                {
                    Console.WriteLine($"{CalculeParkingFee(ref hours, ref minutes).ToString("F2")}$");
                }
            }
        }

        public static float CalculeParkingFee(ref int hoursI, ref int min)
        {
            float hoursTax;
            float minTax;

            if(hoursI == 1)
            {
                hoursTax = 3.50f;
            }else if(hoursI >= 2 && hoursI <= 5)
            {
                hoursTax = hoursI * 2f;
            }else if(hoursI >= 6)
            {
                hoursTax = hoursI * 1.50f;
            }
            else
            {
                hoursTax = 0;
            }

            minTax = (min / 10) * 0.166666667f;

            return hoursTax + minTax;
        }
    }
}
