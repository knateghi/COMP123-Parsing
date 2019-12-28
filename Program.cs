using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {

            //testing the "TryParse()
            //string entryString;
            //int score;
            //Console.Write("Enter ur scroe: ");
            //entryString = Console.ReadLine();
            //int.TryParse(entryString, out score);
            //Console.WriteLine($"your score is {score}");


            ////testing the "OUT" keyboard to change the value of a paramative type in the whole class
            //int first = 12, second = 2;
            //Console.WriteLine($"first= {first} ,second={second}\n");

            //InputMethod(out first, out second);
            //Console.WriteLine($"After coming back from the method: first={first}, second={second}");

            ////testing the "OUT" keyboard by entering an array:
            //DisplayStrings("Koby");
            //DisplayStrings("Ahmed", "Koby", "Reyhan");
            Console.WriteLine(readUntilEnd()); 
            Console.ReadKey();
        }
        public static void InputMethod(out int firstNum, out int secondNum)
        {
            string s1, s2;
            Console.Write("enter first integer: ");
            s1 = Console.ReadLine();
            Console.Write("enter second integer: ");
            s2 = Console.ReadLine();

            firstNum = int.Parse(s1);
            secondNum = Convert.ToInt32(s2);
        }

        public static void DisplayStrings(params string[] people)
        {
            foreach(string person in people)
            {
                Console.Write($"{person} ");
            }
            Console.WriteLine();
        }

       /*
        * this method keeps reading from the console until the "end" word is entered
        * 
        */
        public static string[] readUntilEnd()
        {
            string[] inputs = new string[50];
            int inputCounte = 0;
            
            do
            {
                Console.Write("Enter your name or end to exit: ");
                inputs[inputCounte] = Console.ReadLine();
                if (inputs[inputCounte]=="end")
                {
                    inputCounte = -1;
                    break;
                }
                else
                {
                    inputCounte++;
                }

            } while (inputCounte != -1);
            
             return inputs;
            

        }
    }
}
