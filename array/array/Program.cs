using System;
using System.Collections;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add("Example");
            a1.Add(true);

            Console.WriteLine(a1.Count);
            Console.WriteLine(a1.Contains(2));
            Console.WriteLine(a1[1]);
            a1.RemoveAt(1);
            Console.WriteLine(a1[1]);
            Console.ReadKey();
        }
    }
}
