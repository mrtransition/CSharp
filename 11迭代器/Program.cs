using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11迭代器
{
    class Program
    {

        public static IEnumerable SimpleList()
        {
            yield return "string 1";
            yield return "string 2";
            yield break;
            yield return "string 3";

        }
        static void Main(string[] args)
        {
            //foreach(string item in SimpleList())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            Primes primesFrom2To1000 = new Primes(2, 1000);
            foreach(long i in primesFrom2To1000)
            {
                Console.Write("{0}\t", i);
            }

            Console.ReadKey();
        }
    }

    public class Primes
    {
        private long min;
        private long max;

        public Primes() : this(2,100)
        { }

        public Primes(long minimum,long maximum)
        {
            if (min < 2)
                min = 2;
            else
                min = minimum;

            max = maximum;
        }

        public IEnumerator GetEnumerator()
        {
            for(long possiblePrime = min;possiblePrime <= max;possiblePrime++)
            {
                bool isPrime = true;
                for(long possibleFactor = 2; possibleFactor <= (long)Math.Floor(Math.Sqrt(possiblePrime));possibleFactor++)
                {
                    long remainderAfterDivision = possiblePrime % possibleFactor;
                    if(remainderAfterDivision == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    yield return possiblePrime;
                }
            }
        }

    }

}
