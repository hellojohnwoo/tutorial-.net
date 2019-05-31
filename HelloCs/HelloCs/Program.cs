using System;

namespace HelloCs
{
    class MainClass
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
            Console.Write(args.Length); // HelloCs test1 test2 -> args : 2

            // Console.WriteLine("Hello " + args[0]); // no args -> error -> just build!


            Console.ReadKey();
        }
    }
}
