namespace MethodExercicesFirstBattery
{
    public class Program
    {
        public static void Main()
        {
            const string IntroMsg = "How many hours have you been parked?";
            const string EvenPositonsMsg = "Addition of even numbers: {0}";
            const string OddPositionsMsg = "Exponent of odd numbers: {0}";
            const string HighLowMsg = "Highest number: {0}, Lowest number: {1}";
            const string ErrorMsg = "Error, you must put an integer number (> 0)";

            int num = 0;
            bool numValid = false;
            string numStrg = num.ToString();
            int sumEven = 0;
            int prodOdd = 1;
            int highestNum = 0;
            int lowestNum = 1;
            int digit;
            int pos;


            while (!numValid)
            {
                Console.WriteLine(IntroMsg);
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
                if (num > 0f)
                {
                    numValid = true;
                }
                else
                {
                    Console.WriteLine(ErrorMsg);
                }

                if (numValid)
                {
                    numStrg = num.ToString();
                    for (int i = 0; i < numStrg.Length; i++)
                    {
                        digit = numStrg[i] - '0';
                        pos = i + 1;
                        if (pos % 2 == 0)
                        {
                            sumEven = SumNumbers(ref digit, ref sumEven);
                        }
                        else
                        {
                            prodOdd = MultiplyNumbers(ref digit, ref prodOdd);
                        }
                        highestNum = HigestNumber(ref digit, ref highestNum);

                        lowestNum = LowestNumber(ref digit, ref lowestNum);
                    }
                    Console.WriteLine(EvenPositonsMsg,sumEven);
                    Console.WriteLine(OddPositionsMsg, prodOdd);
                    Console.WriteLine(HighLowMsg, highestNum, lowestNum);
                }
            }
        }
        public static int SumNumbers(ref int numEven, ref int totalEven)
        {
            return totalEven += numEven;
        }

        public static int MultiplyNumbers(ref int numOdd, ref int totalOdd)
        {
            return totalOdd *= numOdd;
        }

        public static int HigestNumber(ref int num, ref int highNumber)
        {
            if(num > highNumber)
            {
                highNumber = num;
            }
            return highNumber;
        }
        public static int LowestNumber(ref int num, ref int LowNumber)
        {
            if (num < LowNumber)
            {
                LowNumber = num;
            }
            return LowNumber;
        }
    }


}
