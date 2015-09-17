using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using PrimeTime.Interview.App.Helpers;
using PrimeTime.Interview.App.Enumerations;



namespace PrimeTime.Interview.App.Classes
{
    /// <summary>
    /// This class is used for Generation and Printing of Prime Numbers
    /// </summary>
    class PrimeInvestigator  
    {
        public int inputInteger { get; set; }
        private ArrayList primenumbers;

        //constructor
         public PrimeInvestigator()
        {
             // init new arraylist to store list of prime numbers
            primenumbers = new ArrayList();
              
        }

        // generate list of prime numbers and stores in internal array list 
        private void generatePrimeNumbers(int n)
        {

               //clear array list
            primenumbers.Clear();

            // find the number of 2s that divide n
            while (n % 2 == 0){
                n = n / 2;
                primenumbers.Add(2); // store factors of 2
            }

            // find the number of old numbers that divide
            for (int i = 3; i <= Math.Sqrt (n); i = i + 2)
            {
                // While i divides n, store i and divide n
                while (n % i == 0) {
                    n = n / i;
                    primenumbers.Add(i); // store factors of 3
                 }
            }

            // Only prime numbers 
            if (n >= 2) primenumbers.Add(n);
            
            // check to see if we include "1" as this number has no factors and must be * by 1
            if (primenumbers.Count == 1) primenumbers.Add(1);

              
        }

        // print print numbers from internal array list 
        public string printPrimeNumbers()
        {
            // setup screen for printing. 
            Util.clearprompt();
            Util.sendPrompts(Prompts.Congrats);
            

            //generate prime number
            generatePrimeNumbers(inputInteger);

            // sort numbers before printing
            primenumbers.Sort();
           
            return String.Format("{0} - {1} {2}", inputInteger, String.Join(",", primenumbers.ToArray()), Environment.NewLine);

        }

        // clean up internal objects 
        public  void Cleanup()
        {

            primenumbers = null; 

        }
        
       
         
    } // end class



}
