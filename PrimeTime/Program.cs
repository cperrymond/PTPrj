using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using PrimeTime.Interview.App.Classes;
using PrimeTime.Interview.App.Helpers; 


namespace PrimeTime.Interview.App
{
    /// <summary>
    /// Main program that takes input of a file (e.g. seed.txt) that contains integers 
    /// The program then reads each integer and generates the prime factors of the number and 
    /// returns the output next to the number. Output shown should * and equal the original input number. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            // Fetch file name and load content
            FileLoader f = new FileLoader();

            PrimeInvestigator PI = new PrimeInvestigator();

            StringBuilder sb = new StringBuilder();

            foreach (var item in f.content)
            {
                int number;
                bool result = Int32.TryParse(item, out number);
                
                if (result)
                {
         
                    PI.inputInteger = number; // set the integer to be processed
                    sb.Append(PI.printPrimeNumbers() + Environment.NewLine); // Append Prime results to string builder. 
                   
                }
            }
           
            // write solution to screen 
            Util.writeLine("", 50); // add spacing;
            Util.writeLine(sb.ToString(),50);
            Util.getKeyInput(); 

            // release objects
            PI.Cleanup(); 

            // clean up 
           f = null; 
            PI = null;
            sb = null;


        }
    } // end main Program

}