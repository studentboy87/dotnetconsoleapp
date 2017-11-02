using System;

namespace FirstCore
{
    class Program
    {
        static void Main(string[] args)
        {
	
            Console.WriteLine("Hello Git!");
	    Console.WriteLine(JsonConvert.SerializeObjects(args));
        }
    }
}
