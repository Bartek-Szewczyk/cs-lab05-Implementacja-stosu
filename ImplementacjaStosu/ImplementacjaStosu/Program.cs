using System;

namespace Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            StosWLiscie<string> s = new StosWLiscie<string>();
            s.Push("km");
            s.Push("aa");
            s.Push("xx");

            string[] tabPrzed = s.ToArray();
            s.Push("km");
            s.Pop();
            string[] tabPo = s.ToArray();

            foreach (var x in tabPrzed)
                Console.WriteLine(x);
            Console.WriteLine(s.Count);
            Console.WriteLine();
            foreach (var x in tabPo)
                Console.WriteLine(x);
            Console.WriteLine(s.Count);



        }
    }
}
