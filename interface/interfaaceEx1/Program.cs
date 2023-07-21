using System;

namespace interfaaceEx1
{
    interface Test1
    {
        void add (int n1,int n2);
    }
    interface Test2:Test1
    {
        void mul (int n1,int n2);
    }
    public class implementc1 :Test1
    {
        public void add(int n1,int n2)
        {
            Console.WriteLine($"sum of {n1} and {n2} is {n1+n2}");
        }
     


    }
    public class implementc2 :Test2
    {
        public void add(int n1,int n2)
        {
            Console.WriteLine($"Addition  of {n1} and {n2} is {n1 + n2}");
        }
        public void mul(int n1, int n2)
        {
            Console.WriteLine($"multi of {n1} and {n2} is {n1 * n2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            implementc1 implementc1 = new implementc1();
            implementc1.add(1,2);
            implementc2 implementc2 = new implementc2();
            implementc2.add(7,2); implementc2.mul(2,8);
           // Console.WriteLine("Hello World!");
        }
    }
}
