using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public enum Convertation
    {
        Usd = 1,
        Eur = 2,
        Rub = 3,
        Byn = 4
    }
    public class BaseClass
    {
        public double Usd { get; set; }
        public double Eur { get; set; }
        public double Rub { get; set; }
        public double Byn { get; set; }
        public BaseClass (double usd, double eur, double rub)
        {
            Usd = usd * 2;
            Eur = eur * 2.5;
            Rub = rub / 3.3;
            
        }

        public virtual void Converter(double money, Convertation con1, Convertation con2)
        {
            switch (con1)
            {
                case Convertation.Usd:
                    Usd *= 2;
                    break;
                case Convertation.Eur:
                    Eur *= 2.5;
                    break;
                case Convertation.Rub:
                    Rub /= 3.3;
                    break;
                case Convertation.Byn:
                    break;
                default:
                    break;
            }
            switch (con2)
            {
                case Convertation.Usd:
                    Usd /= 2;
                    break;
                case Convertation.Eur:
                    Eur /= 2.5;
                    break;
                case Convertation.Rub:
                    Rub *= 3.3;
                    break;
                case Convertation.Byn:
                    break;
                default:
                    break;
            }

            double sum = money *;
            Console.WriteLine(sum);
        }
    }
}
