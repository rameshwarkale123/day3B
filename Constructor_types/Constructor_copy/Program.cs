using System;

namespace Constructor_copy
{
    public class copyConstructor
    {
        int x;
        public copyConstructor(int i)
        {
            x = i;
        }
        public copyConstructor(copyConstructor obj)
        {
            x = obj.x;
        }
        public void display()
        {
            Console.WriteLine($"Value of x = {x}");
        }
       
       
    }
    internal class program
    {
        static void Main(string[] args)
        {
            copyConstructor copy = new copyConstructor(123);
            copy.display();
            copyConstructor copy1 = new copyConstructor(copy);
            copy1.display();
        }
    }

    
}
