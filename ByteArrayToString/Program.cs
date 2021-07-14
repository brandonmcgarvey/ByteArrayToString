using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

namespace ByteArraryToString
{
    class Program
    {
        private static List<byte> byteList = new List<byte>();
        private static List<string> stringList = new List<string>();
        private static string[] Values { get; set; }
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                Values = args;
                if (args[0].ToLower() == "-bytearray")
                {
                    CreateList();

                    byte[] byteArray = byteList.ToArray();
                    string ByteArrayToString = Encoding.Default.GetString(byteArray);

                    Console.WriteLine(ByteArrayToString);
                }
                else if (args[0].ToLower() == "-string")
                {
                    CreateList();
                    foreach (var s in stringList) Console.Write(s);
                }
                else throw new Exception("\nInvalid parameter. Valid parameters: -ByteArray or -String.\n");
            }
            else throw new Exception("\nYou must specify a -ByteArray or -String parameter.\n");

        }

        static void CreateList()
        {
            if (Values[0].ToLower() == "-bytearray")
            {
                for (int i = 1; i <= Values.Length - 1; i++) if (byte.TryParse(Values[i], out byte x)) byteList.Add(x);
            }
            else if (Values[0].ToLower() == "-string")
            {
                for (int i = 1; i <= Values.Length - 1; i++) stringList.Add(Values[i]);
            }
        }
    }
}
