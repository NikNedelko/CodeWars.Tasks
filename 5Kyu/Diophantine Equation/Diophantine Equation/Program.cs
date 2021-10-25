using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Diophantine_Equation
{

    public class Dioph
    {

        public static string solEquaStr(long n)
        {

            string secResult = "[";
            Console.WriteLine(n);
            if (n >= 9000000000)
            {
                for (long i = n; i >= Math.Sqrt(n); i--)
                {
                    if (n % i == 0)
                    {
                        long j = n / i;
                        if ((i + j) % 2 == 0 && (j - i) % 4 == 0)
                        {
                            if (secResult != "[")
                            {
                                secResult += ", ";
                            }

                            long x = (i + j) / 2;
                            long y = (j - i) / 4;

                            if (secResult == "[")
                            {
                                i = x / 6;
                            }
                            if (secResult != "[")
                            {
                                i -= x;
                            }
                            i = i - i / 2;
                            secResult += $"[{x}, {y * -1}]";

                        }
                    }
                }
                secResult += "]";
                Console.WriteLine();
                return secResult;
            }
            if (n >= 900000000)
            {//если чётное 
                if (n % 2 == 0)
                {
                    for (long i = n - n / 4 + 1; i >= Math.Sqrt(n); i--)
                    {
                        if (n % i == 0)
                        {
                            long j = n / i;
                            if ((i + j) % 2 == 0 && (j - i) % 4 == 0)
                            {
                                if (secResult != "[")
                                {
                                    secResult += ", ";
                                }

                                long x = (i + j) / 2;
                                long y = (j - i) / 4;

                                if (secResult == "[")
                                {
                                    i = n / 4;
                                }
                                if (secResult != "[")
                                {
                                    i -= x;
                                }
                                i = i - i / 4;
                                secResult += $"[{x}, {y * -1}]";

                            }
                        }
                    }
                    secResult += "]";
                    Console.WriteLine();
                    return secResult;
                }
                //////////////// // если не чётное 
                else
                {
                    for (long i = n; i >= Math.Sqrt(n); i--)
                    {
                        if (n % i == 0)
                        {
                            long j = n / i;
                            if ((i + j) % 2 == 0 && (j - i) % 4 == 0)
                            {
                                if (secResult != "[")
                                {
                                    secResult += ", ";
                                }

                                long x = (i + j) / 2;
                                long y = (j - i) / 4;
                                if (secResult == "[")
                                {
                                    i = n / 2;
                                }
                                if (secResult != "[")
                                {
                                    i -= x / 2;
                                }
                                i = i - i / 4;
                                secResult += $"[{x}, {y * -1}]";

                            }
                        }
                    }
                    secResult += "]";
                    Console.WriteLine();
                    return secResult;
                }
            }
            /////////////общий случай
            for (long i = n; i >= Math.Sqrt(n); i--)
            {
                if (n % i == 0)
                {
                    long j = n / i;
                    if ((i + j) % 2 == 0 && (j - i) % 4 == 0)
                    {
                        if (secResult != "[")
                        {
                            secResult += ", ";
                        }

                        long x = (i + j) / 2;
                        long y = (j - i) / 4;

                        secResult += $"[{x}, {y * -1}]";


                    }
                }
            }
            secResult += "]";
            Console.WriteLine();
            return secResult;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            long Diop = new long();


            string final = "";


            Diop = 90000001;

            //final = Dioph.solEquaStr(Diop);

            System.Console.WriteLine(final);


            Diop = 90000004;

            //final = Dioph.solEquaStr(Diop);

            System.Console.WriteLine(final);


            Diop = 9000000041;

            final = Dioph.solEquaStr(Diop);

            System.Console.WriteLine(final);
            System.Console.ReadLine();

        }
    }
}
