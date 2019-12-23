using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public class Converter : BaseClass
    {
        public Converter(double usd, double eur, double rub) : base(usd, eur, rub)
        {

        }

        public override double Convert(double money, Curency cur1, Curency cur2)
        {


            try
            {
                var sum = base.Convert(money, cur1, cur2);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success");
                Console.ResetColor();
                Console.WriteLine($"Input : {money} {cur1 }");
                Console.WriteLine($"Output : {sum} {cur2}");
                return sum;

                
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failure");
                Console.ResetColor();
                throw ;
            }
        }


    }
}
