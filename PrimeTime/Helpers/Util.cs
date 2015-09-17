using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeTime.Interview.App.Classes;
using PrimeTime.Interview.App.Enumerations;


namespace PrimeTime.Interview.App
{
    namespace Helpers
    {
        /// <summary>
        /// Helper Utilities class used for formatting and writing to console. 
        /// </summary>
        class Util
        {

            // method returns specified prompt based on option passed 
            public static void sendPrompts(Prompts p)
            {
                string promptMessage;

                switch (p)
                {
                    case Prompts.AskforFile:
                        promptMessage = "Please Provide A Name for Input File.";
                        break;
                    case Prompts.InValidFile:
                        clearprompt();
                        promptMessage = "The filename you entered is not valid! Please try your requested again.";
                        break;
                    case Prompts.Congrats:
                        promptMessage = "Congrats! That's all folks...Press any key to quit";
                        break;
                    default:
                        promptMessage = "";
                        break;
                }

                if (promptMessage != "")
                    writeLine(promptMessage);

            }

            // clears screen 
            public static void clearprompt()
            {
                Console.Clear();

            }
            
            // get input 
            public static string getInput()
            {
                return Console.ReadLine();
            }

            // write input 
            public static void writeLine(string textinput,int padding = 0)
            {
                Console.WriteLine(textinput.PadLeft(padding,' '));

            }

            // get formatting input 
            public static string formatLine(string textinput,int padding = 0)
            {
                return textinput.PadLeft(padding, ' ');

            }


            // return a blank newline
            public static string writeReturn()
            {
                return Environment.NewLine;
            }

            // get key input 
            public static void getKeyInput()
            {
                Console.ReadKey();
            }


        }


    }
}