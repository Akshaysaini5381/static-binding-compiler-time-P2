using System;

namespace static_binding_compiler_time_P2
{
    class MyClass
    {
        public int x = 100;
    }
    class Program:MyClass
    {
        public int x = 200;

        static void Main(string[] args)
        {
            
            MyClass obj = new Program();
            Console.WriteLine(obj.x+" "+obj.x);
        }
    }
}
