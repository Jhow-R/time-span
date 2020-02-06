using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Representa uma DURAÇÃO
             * É um tipo valor(struct)
             */

            Duracoes();
            Propriedades();
            Operacoes();

            Console.ReadLine();
        }

        private static void Operacoes()
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            Console.WriteLine(sum);

            TimeSpan dif = t1.Subtract(t2);
            Console.WriteLine(dif);

            //TimeSpan mult = t2.Multiply(2.0);
            //Console.WriteLine(mult);

            //TimeSpan div = t2.Divide(2.0);
            //Console.WriteLine(div);
        }

        private static void Propriedades()
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            Console.WriteLine(t1);

            TimeSpan t2 = TimeSpan.MinValue;
            Console.WriteLine(t2);

            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
        }

        private static void Duracoes()
        {

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan(900000000L);
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(2, 11, 21);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t8);

            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t9);

            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t10);

            TimeSpan t11 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t11);
        }
    }
}
