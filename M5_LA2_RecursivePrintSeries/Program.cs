using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_LA2_RecursivePrintSeries
{
    //Write a recursive function(s) that prints both the series and the summation of the following equation: 1+x+x2+x3+x4+ ... xn= sum (x to the power of Y)
    //
    class Program
    {

        static int XpowerN(int x, int y)
        {
            if(y==0) return 1;                          //set up recursive branch 
            return x*XpowerN(x, y-1);                     //interested to calulate x to the power of Y when y = 1 =x, when y=2 return x squares, when y=3 x = return x3
         
        }
        //produce numbers from 0-n
        /*
         static int Sum(int x, int y)
         {
             if (y == -1) return 0;                          //set up recursive branch - this will allow us to incude o
             int sum= XpowerN(x, y) + Sum(x, y - 1);           //return the current term plus the recursive term
             //Sum(x, y - 1);                     //interested to calulate x to the power of N when y = 1 =x, when y=2 return x squares, when y=3 x = return x3
             //Console.Write(y + " ");             //produces numbers from 0 to y- now need to implement y is the power 
             Console.Write(XpowerN(x, y)+ "+");   //very close just add the summation in- cannot see this line if there is a return statement- nothing executed- use variabel to store result insead of return
             return sum;
         }*/


        //another method using a parameter istead of a return function
        static void Sum(int x, int y, ref int sum1)
        {
            if (y == -1) return;                          //set up recursive branch - this will allow us to incude o- but just returns the recursive funciton
            sum1 = sum1 + XpowerN(x, y);                //how to update the summation field
            Sum(x, y - 1, ref sum1); 
            Console.Write(XpowerN(x, y) + "+");   //print the series  return
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power y:");
            int y = int.Parse(Console.ReadLine());

            // Console.WriteLine(XpowerN(x, y));
            //Console.WriteLine("\b=" + Sum(x, y));                       //this displays the series  //\b gets rid of last + sign and replaces it with an = sign 
            //Sum(x, y);

            int result = 0;
            Sum(x, y, ref result);
            Console.WriteLine("\b=" + result);

            Console.Read();


        }
    }
}
