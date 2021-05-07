using System;
using methods;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            Console.Out.Write("Enter the encryption key ");
            var encKey=Console.In.ReadLine();
            var encKeyArr = Class.convert (encKey.ToCharArray());
            Class.checkKey(encKey, encKeyArr);

            Console.Out.Write("Enter the Message ");
            var msg = Console.In.ReadLine();
            var msgArr = Class.convert (msg.ToCharArray());
            Class.checkMsg(msg);

            var Result = Class.Output(encKeyArr, msgArr);
                Console.Out.Write($"\nKey    : {encKey}\nMessage: {msg}\nOutput : {Result}");
            

            Console.ReadKey();
        } 
    }
}
