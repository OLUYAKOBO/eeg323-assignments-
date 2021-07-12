using System;

namespace newi
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter values a,b,c,d,e and f");
          Console.WriteLine("Enter a: ");
          
          double a =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b: ");
             double b =Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter c: ");
             double c =Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter d: ");
             double d =Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter e: ");
             double e =Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter f: ");
             double f =Convert.ToInt32(Console.ReadLine());

             double  Determinant = (a*e)-(b*d);
             double changeInX = (c*e)-(b*f);
             double changeInY = (a*f)-(c*d);

          if (Determinant == 0)
          Console.WriteLine("The equation has no solution");
           else {
          double x = changeInX/Determinant;
          double y = changeInY/Determinant;

          Console.WriteLine("The value of \n X is {0} \n Y is {1}", x,y);
        }
       
        }
       


         
         
        
    }
}
