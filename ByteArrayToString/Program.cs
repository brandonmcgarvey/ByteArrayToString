using System;
using System.Collections.Generic;

namespace ByteArraryToString
{
    class Program
    {        
        private static List<string> stringList = new List<string>();
        private static List<int> intList = new List<int>();
        private static string[] Arguments { get; set; }
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                Arguments = args;
                if (args[0].ToLower() == "-bytearray")
                {
                    ConvertToAsciiCharsList();
                    foreach (var i in intList) Console.Write((char)i);
                }
                else if (args[0].ToLower() == "-string")
                {
                    ConvertToAsciiCharsList();
                    foreach (var s in stringList) Console.Write(s);
                }
                else throw new Exception("\nInvalid parameter. Valid parameters: -ByteArray or -String.\n");
            }
            else throw new Exception("\nYou must specify a -ByteArray or -String parameter.\n");

        }

        static void ConvertToAsciiCharsList()
        {
            if (Arguments[0].ToLower() == "-bytearray")
            {
                for (int i = 1; i <= Arguments.Length - 1; i++)
                {
                    int val = Convert.ToInt32(Arguments[i],16);
                    intList.Add(val);                    
                }
            }
            else if (Arguments[0].ToLower() == "-string")
            {
                for (int i = 1; i <= Arguments.Length - 1; i++) stringList.Add(Arguments[i]);
            }
            
        }
    }
}
