using System;

namespace Example1
{

    class A
    {
        protected int x = 123;
    }

    class D : A { }

    class C : B { }

    class B : A
    {
        public int GetX() { return x; }

        public static void Uruchom()
        {
            A a = new A();
            B b = new B();
            C c = new C();
            D d = new D();

            //jaki kod
           
         //  a.x = 10;

          //  int x = 10;

            //żadna z pozostałych instrukcji nie jest poprawna


           // this.x = 10;

           int y = c.GetX();

           c.x = 10;

           // d.x = 10;

           // x = 10;

            b.x = 10;
            
        }

        public void Test()
        {
            //...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            //...
        }
    }
}
