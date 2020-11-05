/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
/*
 * Austin Kirk
 * kirkai@mail.uc.edu
 * IT3045C/Term 1/2020
 * Due 11/5/2020
 * Assignment07
 * Muscular Moose class to protect us from evil
 * Visual C# How to Program (6th Edition) by Paul Deitel and Harvey Deitel
*/
using System;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class MuscularMoose : FantasticBeast
    {
        public override void SayHello()
        {
            //dynamically determines the name of the class
            Console.WriteLine("Hello From" + this.GetType().Name);
        }

        public override void RunThread()
        {
            //computes the largest prime factor
            long number = Convert.ToInt64(request);
            response = Convert.ToString(LargestPrimeFactor(number));
        }
        private static long LargestPrimeFactor(long number)
        {
            long i = 2;
            while (i * i <= number)
            {
                if (number % i == 0)
                {
                    number /= i;
                }
                else
                {
                    ++i;
                }
            }
            return number;
        }
    }
}