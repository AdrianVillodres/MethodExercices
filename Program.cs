using System;

namespace MethodExercicesFirstBattery
{
    public class Program
    {
        public static void Main()
        {
            const string InputMsg = "Which document you have: 1.DNI 2.NIE";
            const string IntroDniMsg = "Give me your dni";
            const string IntroNieMsg = "Give me your nie";
            const string ValidDocMsg = "Your document is valid";
            const string InvalidDocMsg = "Your document is invalid";            
            const string ErrorMsg = "Error, you must put an integer number (> 0 / < 3)";

            string doc;
            int num = 0;
            bool numValid = false;
            bool docValid = false;

            while (!numValid)
            {
                numValid = Validate(ref num, InputMsg, ErrorMsg);
            }
            if (numValid)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine(IntroDniMsg);
                        doc = Console.ReadLine();
                        docValid = ValidateFormatDni(doc);
                        if (docValid)
                        {
                            Console.WriteLine(ValidDocMsg);
                        }
                        else
                        {
                            Console.WriteLine(InvalidDocMsg);
                        }
                            break;
                    case 2:
                        Console.WriteLine(IntroNieMsg);
                        doc = Console.ReadLine();
                        docValid = ValidateFormatNie(doc);
                        if (docValid)
                        {
                            Console.WriteLine(ValidDocMsg);
                        }
                        else
                        {
                            Console.WriteLine(InvalidDocMsg);
                        }
                        break;
                }
            }
        }

        public static bool Validate(ref int num, string introMsg, string errorMsg)
        {
            Console.WriteLine(introMsg);

            try
            {
                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine(errorMsg);
                    return false;
                }

                return true;
            }
            catch (OverflowException)
            {
                Console.WriteLine(errorMsg);
            }
            catch (FormatException)
            {
                Console.WriteLine(errorMsg);
            }
            catch (Exception)
            {
                Console.WriteLine(errorMsg);
            }

            return false;
        }



        public static bool ValidateFormatDni(string document)
        {
            int nums;
            char letter;
            char[] letters = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };


            nums = int.Parse(document.Substring(0, 8));
            letter = char.Parse(document.Substring(8));

            //To visualize the parameters
            /*Console.WriteLine(nums);
            Console.WriteLine(letter);*/

            return (char)letter == letters[nums % 23];
        }

        public static bool ValidateFormatNie(string document)
        {
            int nums;
            char letter;
            char firstLetter;
            char[] letters = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            firstLetter = char.Parse(document.Substring(0, 1));
            nums = int.Parse(document.Substring(1, 7));
            letter = char.Parse(document.Substring(8));
           
            //To visualize the parameters
            /*Console.WriteLine(nums);
            Console.WriteLine(letter);
            Console.WriteLine(firstLetter);*/

            return (char)letter == letters[nums % 23] && firstLetter == 'X' || firstLetter == 'Y' || firstLetter == 'Z';
        }



    }
}
