namespace MethodExercicesFirstBattery
{
    public class Program
    {
        public static void Main()
        {
            const string NumberInputMsg = "Give me a number";
            const string ErrorMsg = "Error, you must put an integer natural number (> 0)";
            const int MinValue = 2;
            const int MaxValue = 10;

            int num = 0;
            bool numVal = false;

            while (!numVal)
            {
                Console.WriteLine(NumberInputMsg);
                try
                {
                    num = Int32.Parse(Console.ReadLine());
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
                if (num > 0)
                {
                    numVal = true;
                }
                else
                {
                    Console.WriteLine(ErrorMsg);
                }
            }
            Console.WriteLine(ValidateNumberInRange(num, MinValue, MaxValue));

        }
        public static bool ValidateNumberInRange(int numV, int min, int max)
        {
            return numV >= min && numV <= max;
        }
    }
}
