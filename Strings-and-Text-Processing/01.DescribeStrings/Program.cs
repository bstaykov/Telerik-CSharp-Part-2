namespace _01.DescribeStrings
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        // 1. Describe the strings in C#. What is typical for the string data type? 
        // Describe the most important methods of the String class.

        // string is reference data type. it's imutable (read only). ...
        // this[], IndexOf(), Trim(), Substring(), Join() .... 

        static void Main(string[] args)
        {

            // http://msdn.microsoft.com/en-us/library/system.string%28v=vs.110%29.aspx


            //string a = "123A";
            //string b = a;

            //int result = string.Compare(a, b, true);
            //Console.WriteLine(result);

            //result = string.Compare(a, b, false);
            //Console.WriteLine(result);

            //b = "123a";

            //result = string.Compare(a, b, true);
            //Console.WriteLine(result);

            //result = string.Compare(a, b, false);
            //Console.WriteLine(result);

            //string arr = "a";

            //int[] array = { 1, 2, 3 };

            //arr = arr + array;

            //Console.WriteLine(arr);



            ////string a = "abcaderaertghya";
            ////int index = a.IndexOf("a");

            ////for (int i = 0; i < 2; i++)
            ////{
            ////    index = a.IndexOf("a", index + 1);
            ////}
            ////Console.WriteLine(index);




            //string address = "arena.com";

            //int index = address.LastIndexOf(".");

            //string result = address.Substring(index + 1);

            //Console.WriteLine(result);




            //////string address = @"C:\Path\Some\address.com";

            //////int lastSlash = address.LastIndexOf("\\");

            //////Console.WriteLine(address.Substring(0, lastSlash));


            //////address = @"C:\Some\Path\address.com";

            //////char dirSlash = Path.DirectorySeparatorChar;

            //////lastSlash = address.LastIndexOf(dirSlash);

            //////if (lastSlash != -1)
            //////{
            //////    string directory = address.Substring(0, lastSlash);
            //////    Console.WriteLine(directory);
            //////}




            //string some = " abc def ! ";

            //Console.WriteLine(some + "?");
            //Console.WriteLine(some.Trim() + "?");
            //Console.WriteLine(some.Trim('a', ' ') + "?");
            //Console.WriteLine(some.Replace("a", "AA"));
            //Console.WriteLine(some.Replace('b', 'k'));
            //Console.WriteLine(some.PadLeft(30, '0'));
            //Console.WriteLine(some.TrimEnd() + "?");
            //Console.WriteLine(some.TrimStart(' ', 'a'));
            //Console.WriteLine(some.TrimStart('a', ' '));
            //Console.WriteLine(some.TrimStart('c'));

            //char c = '\\';


            ////////DateTime start = DateTime.Now;
            ////////StringBuilder sb = new StringBuilder();
            ////////for (int i = 0; i < 50000; i++)
            ////////{
            ////////    sb.Append("a");
            ////////}
            ////////DateTime end = DateTime.Now;
            ////////Console.WriteLine(end - start);
            ////////Console.WriteLine(sb.Capacity);

            ////////start = DateTime.Now;
            ////////StringBuilder sb2 = new StringBuilder(56192);
            ////////for (int i = 0; i < 50000; i++)
            ////////{
            ////////    sb2.Append("a");
            ////////}
            ////////end = DateTime.Now;
            ////////Console.WriteLine(end - start);
            ////////Console.WriteLine(sb2.Capacity);

            ////////string s = "";

            ////////start = DateTime.Now;
            ////////for (int i = 0; i < 10000; i++)
            ////////{
            ////////    s += "a";
            ////////}
            ////////end = DateTime.Now;
            ////////Console.WriteLine(end - start);


            ////////StringBuilder sb3 = new StringBuilder();
            ////////for (int i = 0; i < 20; i++)
            ////////{
            ////////    sb3.Append("a");
            ////////}
            ////////Console.WriteLine(sb3.Replace('a' , 'b', 1, 1));
            ////////Console.WriteLine(sb3);
            ////////sb3[sb3.Length - 1] = 'C';
            ////////Console.WriteLine(sb3);
            ////////sb3.Insert(5, "AAA");
            ////////Console.WriteLine(sb3);
            ////////sb3.Insert(0, "A");
            ////////Console.WriteLine(sb3);


            int x = 255;
            Console.WriteLine(x.ToString("D5"));
            Console.WriteLine(x.ToString("X"));
            Console.WriteLine(x.ToString("C"));
            Console.WriteLine(x.ToString("E"));
            Console.WriteLine(x.ToString("F1"));
            double xx = 0.323;
            Console.WriteLine(xx.ToString("P"));
            Console.WriteLine(xx.ToString("P10"));

            //string template = "My name is {0}. I am {1} years old!";
            //string fName = "Dragan";
            //int age = 33;
            //string sentence = string.Format(template, "Ivan", 23);
            //string sentence2 = string.Format(template, fName, age);
            //Console.WriteLine(sentence);
            //Console.WriteLine(sentence2);

            //Console.WriteLine(System.Threading.Thread.CurrentThread.CurrentCulture);//bg
            //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-Ca");
            //Console.WriteLine(System.Threading.Thread.CurrentThread.CurrentCulture);

        }
    }
}
