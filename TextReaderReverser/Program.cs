using System;
using System.IO;

namespace TextReaderReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("file.txt");
            Console.WriteLine("++++ Original text ++++++");
            Console.WriteLine(text);

            var reversed = text.Reverse();

            Console.WriteLine("++++ Original text ++++++");
            Console.WriteLine(reversed);

            File.WriteAllText("reversed-file.txt", reversed);
        }

       

    }
}
