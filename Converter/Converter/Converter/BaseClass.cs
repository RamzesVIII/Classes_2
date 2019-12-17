using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public enum Convertation
    {
        Usd ,
        Eur ,
        Rub ,
        Byn = 4
    }
    public class BaseClass
    {
        public double Usd { get;}
        public double Eur { get;}
        public double Rub { get;}
        public double Byn { get;}
        public BaseClass (double usd, double eur, double rub)
        {
            Usd = usd ;
            Eur = eur ;
            Rub = rub ;
            
        }

        public virtual void Converter(double money, Convertation con1, Convertation con2)
        {
            double operand1 = 0, operand2 = 0;
            switch (con1)
            {
                case Convertation.Usd:
                    operand1 = 2;
                    break;
                case Convertation.Eur:
                    operand1 = 2.5;
                    break;
                case Convertation.Rub:
                    operand1 = 0.033;
                    break;
                case Convertation.Byn:
                    operand1 = 1;
                    break;
                default:
                    break;
            }
            switch (con2)
            {
                case Convertation.Usd:
                    operand2 = 2;
                    break;
                case Convertation.Eur:
                    operand2 = 2.5;
                    break;
                case Convertation.Rub:
                    operand2 = 0.033;
                    break;
                case Convertation.Byn:
                    operand2 = 1;
                    break;
                default:
                    break;
            }

            double sum = money * operand1/ operand2;
            Console.WriteLine(sum);
        }
    }
}
