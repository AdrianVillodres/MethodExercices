namespace MethodExercicesFirstBattery
{
    public class Program
    {
        public static void Main()
        {
            const string IntroMsg = "Give me a natural number";
            const string ErrorMsg = "Error, you must put an integer number (> 0)";

            int num = 0;
            int og = 0;
            int numDiv = 1;
            int count;
            int maxFact = 32;
            int[] primes = new int[maxFact];
            int[] expo = new int[maxFact];
            int index = 0;
            bool numValid = false;
            


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
                    og = num;
                    
                    for (int i = 2; i * i <= num; i++)
                    {
                        count = 0;
                        while (num % i == 0)
                        {
                            num /= i;
                            count++;
                        }
                        if(count > 0)
                        {
                            primes[index] = i;
                            expo[index] = count;
                            index++;
                        }
                    }
                    if (num > 1)
                    {
                        primes[index] = num;
                        expo[index] = 1;
                        index++;
                    }
                    Console.Write($"{og} = ");
                    for (int i = 0; i < index; i++)
                    {
                        Console.Write($"{primes[i]}^{expo[i]} X ");
                    }
                    {

                    }
                }
            }
        }

    }
}
