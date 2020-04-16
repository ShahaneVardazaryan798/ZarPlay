using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace RandomLesson

{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var str = new char[5];
            start: for (int i = 0; i < str.Length; i++)
            {



                str[0] = chars[rd.Next(0, 28)];
                str[i] = chars[rd.Next(28, 57)];
                str[i] = chars[rd.Next(chars.Length)];
                WriteLine(str[i]);
                
            }   
                   
            Thread.Sleep(1000);
                goto start;
            



        }
    }
}
