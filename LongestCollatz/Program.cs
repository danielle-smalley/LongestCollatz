using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The following iterative sequence is defined for the set of positive integers:

                n → n / 2(n is even)
                n → 3n + 1(n is odd)

                Using the rule above and starting with 13, we generate the following sequence:
                13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

                It can be seen that this sequence(starting at 13 and finishing at 1) contains 10 terms.Although it
                    has not been proven yet(Collatz Problem), it is thought that all starting numbers finish at 1.

                Which starting number, under one thousand, produces the longest chain ?

                NOTE : Once the chain starts the terms are allowed to go above one thousand.*/


            //Looking for starting number
            //Under 1,000
            //That produces the longest chain
            //Terms are allowed to go over 1000 once chain starts
            //This is for positive integers
            // If number is even -> number / 2
            //If number is odd -> 3 * number + 1
            //unsure if List will be needed or if I can just handle math/logic in a for loop with some if/whiles

            int lengthOfSequence = 0; //starting sequence length tracker at 0
            int startNumber = 0; //starting with startNumber 0
            int countTracker = 0; //starting tracker for count at 0

            //loop over all numbers under 1000, run the sequence while startNumber is not 1, count length of sequence
            for (int i = 2; i < 1000; i++)
            {
                int lengthTracker = 1;
                startNumber = i; //if chain value is 1/lands at 1, end here until remaining code below

                while (startNumber != 1) //if value is not 1, do the if/else below
                {
                    if (startNumber % 2 == 0)
                    {
                        startNumber /= 2; //for even numbers
                    }//end if
                    else
                    {
                        startNumber = startNumber * 3 + 1; //for odd numbers
                    }//end else
                    lengthTracker++;//counter for length of sequence/chain
                }//end while

                if (lengthTracker > lengthOfSequence)//looks at previous value vs new value
                {
                    lengthOfSequence = lengthTracker;//holds new value 
                    countTracker = i;//holds the iteration the for loop was on.
                }//end if

            }//end for

            Console.WriteLine($"The largest chain producing starting number under 1000 is {countTracker}. The chain length for {countTracker} is {lengthOfSequence - 1}");

            //Unsure why lengthOfSequence is showing one number higher than what the actual answer is. 871 has 178 steps, and without the minus 1 in the formatting above, console displays 179.



        }//end main
    }//end class
}//end namespace
