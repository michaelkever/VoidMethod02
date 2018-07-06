using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod02
{
    public static class InvertText
    {
        public static string Text { get; set; }
        public static string InvText(string userInput)
        {
            string result = string.Empty;
            for (int i = Text.Length - 1; i >= 0; i--)
                result += Text[i];
            return result;
        }
        

    }
    
    class Program
    {

        static void Main(string[] args)
        {
            TwoDivision twoDivision = new TwoDivision();
            Console.WriteLine("Please enter an amount that will be divided by two. \n Make sure to enter it as a whole number, then press enter.");
            int userAmt01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press enter again to be divided by 2.");

            bool userTotal = Int32.TryParse(Console.ReadLine(), out int userAmt02);

            if (userTotal)
            {
                Console.WriteLine("You make about: " + twoDivision.numDivision(userAmt01, userAmt02) + "  per hour.");
            }
            else
            {
                Console.WriteLine("The number " + userAmt01 + " divided by 2 equals: " + twoDivision.numDivision(userAmt01));
            }

            Console.ReadLine();

            Console.WriteLine("Now  for the overloaded method with parameters of 1 and 2 to be added. \n :  " + twoDivision.numDivision01(userAmt01, userAmt02));
            Console.ReadLine();

            Console.WriteLine("Next, add some text and it'll get inverted.");
            userInput = Console.ReadLine();
            Console.WriteLine(InvertText.InvText(userInput));






        }
        


    }   
    
    
}
