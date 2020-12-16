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
            s.Push("abc");

            Console.WriteLine("Długość stosu");
            Console.WriteLine(s.Count);
            Console.WriteLine();

            Console.WriteLine("Indexer");
            Console.WriteLine(s[0]);
            Console.WriteLine();


            Console.WriteLine("Iterator, ToArray");
            string[] tabPrzed = s.ToArray();
            s.Pop();
            s.Push("działa");
            string[] tabPo = s.ToArray();

            foreach (var x in tabPrzed)
                Console.WriteLine(x);

            Console.WriteLine();
            foreach (var x in tabPo)
                Console.WriteLine(x);
           



        }
    }
}
