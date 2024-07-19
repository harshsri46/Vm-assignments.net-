using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    internal class Program
    {
        //delegates declaration
        public delegate string NumberToStringDelegate(int number);
        public delegate void Multicast(int number);

        //implement methods that matches the delegates signature
        public static string ConvertNumberToString(int number)
        {
            return number.ToString();
        }
        
        public static void PrintNumber(int number)
        {
            Console.WriteLine($"message from delegate is {number}");
        }

        public static void PrintStrToInt(int number)
        {
            string strNumber=number.ToString(); 
            int  intNumber=int.Parse(strNumber); 
            Console.WriteLine($"converted string to int {intNumber}");

        }
        public static void displayNumber(int input,NumberToStringDelegate numbertostringdelegate,Multicast multicastdelegate)
        {
            for(int i =1;i<=input;i++)
            {
                //single cast delegate usage
                string numberstr=numbertostringdelegate(i);
                Console.WriteLine($"Converted number to string:{numberstr}" );

                //multicast delegate
                multicastdelegate(i);
            }
        }

        public static void Main(string[] args)
        {
            NumberToStringDelegate numbertostringdelegate = new NumberToStringDelegate(Program.ConvertNumberToString);

            Multicast multicastdelegate = new Multicast(PrintNumber);
            multicastdelegate += PrintStrToInt;

            displayNumber(5, numbertostringdelegate, multicastdelegate);
        
        }
    }
}
