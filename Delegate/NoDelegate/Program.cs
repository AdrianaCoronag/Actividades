using System;

namespace Delegate.BasicDelegete
{
    public delegate void SimpleDelegate();

    class TestDelegete
    {
        public static void MyFunc()
        {
            Console.WriteLine("I was called by delegate ...");
        }

        static void Main(string[] args)
        {
            SimpleDelegate simpleDelegate = new SimpleDelegate(MyFunc);
            simpleDelegate(); 
        }
    }
}
