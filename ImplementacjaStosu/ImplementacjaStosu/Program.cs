using System;

namespace Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            StosWTablicy<string> s = new StosWTablicy<string>(2);
            s.Push("km");
            s.Push("aa");
            s.Push("xx");
            s.Push("xx"); s.Push("xx"); s.Push("xx"); s.Push("xx"); s.Push("xx"); s.Push("xx"); s.Push("xx");
            foreach (var s1 in s.TopToBottom)
                Console.WriteLine(s1);

            Console.WriteLine();
            Console.WriteLine(s.Count);
            s.TrimExcess();
            foreach (var x in s.ToArray())
                Console.WriteLine(x);
            Console.WriteLine(s.Count);
            Console.WriteLine();

            s.Push("abc");
            foreach (var x in s.ToArray())
                Console.WriteLine(x);
            Console.WriteLine(s.Count);


        }
    }
}
