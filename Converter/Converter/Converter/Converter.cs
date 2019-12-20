using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public class Converter : BaseClass
    {
        public double Usd { get; }
        public double Eur { get; }
        public double Rub { get; }
        public double Byn { get; }

        public Converter (double usd, double eur, double rub) : base (usd, eur, rub)
        {
            
        }
    }
}
