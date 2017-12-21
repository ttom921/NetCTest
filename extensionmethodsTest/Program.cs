using System;

namespace extensionmethodsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "123456789";
            //Console.WriteLine(StringExtension.Reverse(s));
            //Console.WriteLine(s.Reverse());
            Console.WriteLine(DateTime.Now.ToRocDateString('/'));
            Console.ReadKey();
        }
    }
}
