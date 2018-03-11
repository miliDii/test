using System;

namespace max_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
          
            Console.WriteLine(GetMax(GetMax(num1,num2),num3));
        }

        static int GetMax(int num1, int num2)
        {
           
            if (num1 > num2)
                return num1;
            else
                return num2;


        }
        
    }
}
