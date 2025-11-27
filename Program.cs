namespace MethodExercicesFirstBattery
{
    public class Program
    {
        public static void Main()
        {
            const string NumberInputMsg = "Give me a temperature";
            const string OperationMsg = "Which conversion do you want to do: 1: Celsius to Fahrenhait, 2: Fahrenhait to Celsius, 3: Celsius to Kelvin";
            const string ErrorMsg = "Error, you must put a float number (> 0)";

            float temp = 0;
            int num = 0;
            int tries = 3;
            bool tempVal = false;
            bool numVal = false;

            while (!tempVal)
            {
                Console.WriteLine(NumberInputMsg);
                try
                {
                    temp = float.Parse(Console.ReadLine());
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
                if (temp > 0f)
                {
                    tempVal = true;
                }
                else
                {
                    Console.WriteLine(ErrorMsg);
                }
            }
            while (!numVal && tries > 0)
            {
                Console.WriteLine(OperationMsg);
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine(ErrorMsg);
                    tries--;
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorMsg);
                    tries--;
                }
                catch (Exception)
                {
                    Console.WriteLine(ErrorMsg);
                    tries--;
                }
                if (num > 0 && num <= 3)
                {
                    numVal = true;
                }
                else
                {
                    Console.WriteLine(ErrorMsg);
                    tries--;
                }
            }

            if(numVal && tempVal)
            {
                Console.WriteLine(CalculateTemp(temp, ref num));
            }


        }

        public static float CalculateTemp(float tempI, ref int op)
        {
            float tempConversed = 0f;
            switch (op)
            {
                case 1:
                    tempConversed = tempI * 9 / 5 + 32;
                    break;
                case 2:
                    tempConversed = (tempI - 32) * 5 / 9;
                    break;
                case 3:
                    tempConversed = tempI + 273.15f;
                    break;
            }
            return (float)Math.Round(tempConversed, 2);
        }
        
    }
}
