using System.Threading.Tasks.Dataflow;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TASK15();
        }

        static void TASK9()
        {
            Console.WriteLine("Ededleri daxil edin");
            double a = ReadInt32("a: ", 100000, 1000000);
            double b = ReadInt32("b: ", 100000, 1000000);
            double c = ReadInt32("c: ", 100000, 1000000);

            a = a * 10 / 100;
            b = b * 10 / 100;    
            c = c * 10 / 100;

            double cavab = (a+b+c)*10 / 100;
            Console.WriteLine(cavab);
        }

        static void TASK10()
        {
            Console.WriteLine("Ededleri daxil edin");
            double a = ReadInt32("a: ", 1000, 10000);
            double b = ReadInt32("b: ", 1000, 10000);
            double c = ReadInt32("c: ", 1000, 10000);

            a = a * 1 / 100;
            b = b * 2 / 100;
            c = c * 3 / 100;

            double cavab = a - b - c + (c*7/100);
            Console.WriteLine(cavab);
        }

        static void TASK11()
        {
            Console.WriteLine("Ededleri daxil edin");
            double a = ReadInt32("a: ", 10000, 100000);
            double b = ReadInt32("b: ", 10000, 100000);
            double c = ReadInt32("c: ", 10000, 100000);
            double d = ReadInt32("d: ", 10000, 100000);
               

            double cavab = (a + c) * (b+d)-(c*3/100);
            Console.WriteLine(cavab);
        }

        static void TASK12()
        {
            Console.WriteLine("Ededleri daxil edin");
            double a = ReadInt32("a: ", 100000, 1000000);
            double b = ReadInt32("b: ", 100000, 1000000);
            double c = ReadInt32("c: ", 100000, 1000000);
            double d = ReadInt32("d: ", 100000, 1000000);


            double ededlerinOnFaizCemi = a*10/100+b*10/100+c*10/100+d*10/100;
            double edelerinOnBeshFaizCemi= a * 15 / 100 + b * 15 / 100 + c * 15 / 100 + d * 15 / 100;
            double cavab = (ededlerinOnFaizCemi * edelerinOnBeshFaizCemi * 10 / 100) * 11 / 100;
            Console.WriteLine(cavab);
        }

        static void TASK13()
        {
            Console.WriteLine("Ededleri daxil edin");
            double a = ReadInt32("a: ", 10000, 100000);
            double b = ReadInt32("b: ", 10000, 100000);
            double c = ReadInt32("c: ", 10000, 100000);
            double d = ReadInt32("d: ", 100, 1000);
            double e = ReadInt32("e: ", 100, 1000);


            double beshReqemliEdedinBeshFaizHasili = (a * 5 / 100) * (b * 5 / 100) * (c * 5 / 100);
            double uchReqemliEdedinUchFaizCemi = d * 3 / 100 + e * 3 / 100;
            double cavab = beshReqemliEdedinBeshFaizHasili*10/100+uchReqemliEdedinUchFaizCemi*10/100;
            Console.WriteLine(cavab);
        }

        static void TASK14()
        {
            Console.WriteLine("Ededleri daxil edin");
            double a = ReadInt32("a: ", 100000, 1000000);
            double b = ReadInt32("b: ", 100000, 1000000);
            double c = ReadInt32("c: ", 100000, 1000000);
            double d = ReadInt32("d: ", 100000, 1000000);
            double e = ReadInt32("e: ", 100000, 1000000);
            double f = ReadInt32("f: ", 100000, 1000000);

            double Cem = a+b+c+d+e+f; 
            double ac = a*1000000+c;
            double cavab = ((Cem - ac) * 10 / 100 + e + f) * 11 / 100;
            
            Console.WriteLine(cavab);
        }

        static void TASK15()
        {
            Console.WriteLine("Ededleri daxil edin");
            double a = ReadInt32("a: ", 100000, 1000000);
            double b = ReadInt32("b: ", 10000, 100000);
            double c = ReadInt32("c: ", 10000, 100000);
            double d = ReadInt32("d: ", 1000, 10000);
            double e = ReadInt32("e: ", 1000, 10000);
            double f = ReadInt32("f: ", 100, 1000);
            double g = ReadInt32("g: ", 100, 1000);



            double cavab = (((((f + g + d * e) * 10 + 7 + b + c - (f * g * 10 + 1) + a - d + e + f + g) * 18 / 100) * 3 / 100) * 1 / 100) + b + c;

            Console.WriteLine(cavab);
        }



        static int ReadInt32(string caption, int min, int max)
        {
            int a;
        l1: Console.Write(caption, min, max);
            if (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("eded daxil edin");
                goto l1;
            }

            if (a < max == false) { Console.WriteLine("duzgun araliqda ede daxil edin"); goto l1; }
            if (a >= min == false) { Console.WriteLine("duzgun araliqda ede daxil edin"); goto l1; }

            return a;

        }
    }
}