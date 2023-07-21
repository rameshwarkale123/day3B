using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace para_constractor
{

    public class calculator
    {
        int Num1,Num2;
        public calculator(int num1,int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
         

        }

       public void display()
        {
          int sum = Num1+ Num2;
            Console.WriteLine(sum);


        }


       


    }
    internal class Program
    {

        static void Main(string[] args)
        {
            calculator cal1 = new calculator(12,34);
            cal1.display();
            calculator cal2 = new calculator(23, 45);
            cal2.display();
            

           
        }
    }
}
