using System;

namespace interfaceEx2
{
    interface Cal
    {
        void add(int a, int b);
    }
    
    public class pro : Cal
    {
        public void add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }

    }
    internal class progg
    {
        static void Main(string[] args)
        {
            pro pro = new pro();
            pro.add(1, 2);

        }
    }




   
    
        
    
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
