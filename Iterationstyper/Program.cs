using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterationstyper
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5-1
             *RecursiveOdd(1) = 2+ RecursiveOdd(0)= 2+1=3
             * RecursiveOdd(3)=2+RecursiveOdd(2)=2+2+RecursiveOdd(1)=2+2+1=5
             * RecursiveOdd(5)=2+RecursiveOdd(4)=2+2+RecursiveOdd(3)=2+2+2+RecursiveOdd(2)=6+2+1=9
             * 5-2, 5-3
             */

            Console.WriteLine($" for n=4 the RecursiveEven(4)= {RecursiveEven(4)} ");
            Console.WriteLine($" for n=10 the RecursiveEven(10)= {RecursiveEven(10)} ");
            Console.WriteLine($" for n=2 the RecursiveEven(2)= {RecursiveEven(2)} ");
            Console.WriteLine($" for n=1 the Fibonaccisekvensen(1)= {Fibonaccisekvensen(1)} ");
            Console.WriteLine($" for n=2 the Fibonaccisekvensen(2)= {Fibonaccisekvensen(2)} ");
            Console.WriteLine($" for n=3 the Fibonaccisekvensen(3)= {Fibonaccisekvensen(3)} ");
            Console.WriteLine($" for n=4 the Fibonaccisekvensen(4)= {Fibonaccisekvensen(4)} ");
            Console.WriteLine($" for n=8 the Fibonaccisekvensen(8)= {Fibonaccisekvensen(8)} ");
            Console.WriteLine($" for n=9 the Fibonaccisekvensen(9)= {Fibonaccisekvensen(9)} ");
            Console.WriteLine($" for n=10 the Fibonaccisekvensen(10)= {Fibonaccisekvensen(10)} ");

            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            /*
             * 6-1
             * IterativeOdd (1) =3, IterativeOdd (3)=1+2+2+2=7 ;IterativeOdd (5)=1+2+2+2+2+2=11
             * 6-2, 6-3
             */
            Console.WriteLine($" for n=4 the IterativeEven(4)= {IterativeEven(4)} ");
            Console.WriteLine($" for n=10 the IterativeEven(10)= {IterativeEven(10)} ");
            Console.WriteLine($" for n=2 the IterativeEven(2)= {IterativeEven(2)} ");
            Console.WriteLine($" for n=1 the Fibonacciberäknaren(1)= {Fibonacciberäknaren(1)} ");
            Console.WriteLine($" for n=2 the Fibonacciberäknaren(2)= {Fibonacciberäknaren(2)} ");
            Console.WriteLine($" for n=3 the Fibonacciberäknaren(3)= {Fibonacciberäknaren(3)} ");
            Console.WriteLine($" for n=4 the Fibonacciberäknaren(4)= {Fibonacciberäknaren(4)} ");
            Console.WriteLine($" for n=8 the Fibonacciberäknaren(8)= {Fibonacciberäknaren(8)} ");
            Console.WriteLine($" for n=9 the Fibonacciberäknaren(9)= {Fibonacciberäknaren(9)} ");
            Console.WriteLine($" for n=10 the Fibonacciberäknaren(10)= {Fibonacciberäknaren(10)} ");
            Console.ReadLine();

            /*
             * https://www.globalsoftwaresupport.com/recursion-from-0-to-1/
             * Recursive function (method) calls have something to do with the stack memory. Why? 
             * Because the program has to track during recursion what function (method) called the given function 
             * and what arguments are to be handed over. So somehow we have to track the pending recursive 
             * function calls.
             * So whenever there is a recursive function (method) call it is pushed onto the stack. 
             * Until we hit the base case and we know the sub-result for that given function call. 
             * Then we can backtrack and substitute the values one by one.
             * This is why recursion is at least twice slower than iteration because first,
             * we unfold recursive calls (pushing them onto the stack) until we reach the base case. 
             * Then we traverse the stack and retrieve all recursive calls.
             */
        }

        //5-2
        static int RecursiveEven(int n)
        {
            if (n == 1) return 2;
            return RecursiveEven(n - 1) + 2;

        }

        //5-3
        static int Fibonaccisekvensen(int n)
        {
            if (n == 1 || n==0 ) return n;
            return Fibonaccisekvensen(n - 1) + Fibonaccisekvensen(n - 2);
        }
        //6-2
        static int IterativeEven(int n)
        {
            if (n == 1) return 2;
            int result = 2;
            for (int i = 1; i <n; i++)
            {
                result += 2;
            }
            return result;
        }
        static int Fibonacciberäknaren(int n)
        {       
            if (n == 1 || n == 0) return n;
            int result0 = 0;
            int result1 = 1;
            int result=0;
            for (int i = 1; i < n; i++)
            {
                result = result0 + result1;
                result0 = result1;
                result1 = result;
            }
            return result;
        }
    }
}
