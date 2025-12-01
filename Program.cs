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
            bool valid = false;



            while (!valid)
            {
                Console.WriteLine(HoursParkedMsg);
                Validate( hours, ErrorMsg, ref valid);
            }
            valid = false;
            while (!valid)
            {
                Console.WriteLine(MinutesParkedMsg);
                Validate( minutes, ErrorMsg, ref valid);
            }
            if (valid)
            {
                Console.WriteLine($"{CalculeParkingFee(hours, minutes).ToString("F2")}$");
            }
        }

        public static float CalculeParkingFee( int hoursI,  int min)
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

        public static bool Validate( int time, string ErrorMsg, ref bool valid)
        {
            try
            {
                time = Int32.Parse(Console.ReadLine());
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
            if (time >= 0f)
            {
                valid = true;
            }
            else
            {
                Console.WriteLine(ErrorMsg);
            }
            return valid;
        }
    }
}
