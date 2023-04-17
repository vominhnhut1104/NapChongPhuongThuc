using System;
using System.ComponentModel.DataAnnotations;

namespace ExercisesLesson43
{
    class Exercises3
    {
        static int Max2(int a, int b, int c)
        {
            int Max = 0;
            int max2 = 0;
           
            if (a == b && b == c)
            {
                return a;
            }
            if ( a == b )
            {
                 if (a > c)
                {
                    max2 = c;
                }
                 else max2 = a;
            }
            if (  a == c)
            {
                if (a > b)
                {
                    max2 = b;
                }
                else max2 = a;
            }
            if ( b == c )
            {
                if (b > a)
                {
                    max2 = a;
                }
                else max2 = b;
            }
            if (a != b &&  b != c && c!=a) 
            {
                Max = Math.Max(Math.Max(a, b), c);
            }
            

            if (a < Max && a > b || a < Max && a > c)
                max2 = a;
            if (b < Max && b > a || b < Max && b > c)
                max2 = b;
            if (c < Max && c > b || c < Max && c > a)
                max2 = c;

            return max2;
            
        }

       /* static double  Max2(double a, double b, double c)
        {
            double Max = 0;
            double max2 = 0;
            if (a == b && b == c)
            {
                return a;
            }
           
            if (a == b && a !=c)
            {
                Max = Math.Max(a, c);
            }
            if (a == c && a!=b)
            {
                Max = Math.Max(a, b);
            }
            if (b == c && b!=a)
            {
                Max = Math.Max(b, a);
            }
            if (a != b && b != c && c != a)
            {
                Max = Math.Max(Math.Max(a, b), c);
            }


            if (a < Max && a > b || a < Max && a > c)
                max2 = a;
            if (b < Max && b > a || b < Max && b > c)
                max2 = b;
            if (c < Max && c > b || c < Max && c > a)
                max2 = c;

            return max2;

        }*/
        
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Max2(a, b, c));
            Console.WriteLine("=====================");
           /* double d1 = double.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            double d3 = double.Parse(Console.ReadLine());
            Console.WriteLine("So lon thu 2(double): " + Max2(d1, d2, d3)); // 3 số double
           */
        }
    }

}

/*Cách 2
 * static int Max(int a, int b, int c)
        {
            int max = a;
            if(max < c)
            {
                max = c;
            }
            if(max < b)
            {
                max = b;
            }
            return max;
        }

        static int Min(int a, int b, int c)
        {
            int min = a;    
            if(min > b)
            {
                min = b;    
            }
            if(min > c)
            {
                min = c;
            }
            return min;
        }

        static int SecondMax(int a, int b, int c)
        {
            if(a == b && b == c)
            {
                return a;
            }
            int min = Min(a, b, c);
            int max = Max(a, b, c);
            int secondMax = min;
            if(secondMax < a && a != max)
            {
                secondMax = a;
            }
            if(secondMax < b && b != max)
            {
                secondMax=b;
            }
            if(secondMax < c && c != max)
            {
                secondMax = c;
            }
            return secondMax;
        }
*/