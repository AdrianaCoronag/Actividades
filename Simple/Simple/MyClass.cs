using System;

namespace Simple
{
   public class MyClass
    {
        public delegate void LogHandler(string message);
        public void Process(LogHandler logHandler)
        {
            if (logHandler != null)
            {
                logHandler("Process() begin");
            }

            if (logHandler != null)
            {
                logHandler("Process() end");
            }
        }
    }
    public class TestApplication
    {
        static void Logger(string s)
        {
            Console.WriteLine(s);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass.LogHandler myLogger = new MyClass.LogHandler(Logger);
            myClass.Process(myLogger);
            Console.ReadKey();
        }
    }
}
