using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    public class Generic<T>
    {
        public T Field;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generic<String> g = new Generic<String>();
            g.Field = "Hi";
            Console.WriteLine(g.Field);
            Console.Read();
        }
    }
    //    class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            int a = args.Length;
    //            int b = 1 / a;
    //            Console.WriteLine(a);
    //        }
    //        catch (ArithmeticException e)
    //        {
    //            Console.WriteLine("1");
    //        }
    //        Console.ReadLine();

          
        }
    

