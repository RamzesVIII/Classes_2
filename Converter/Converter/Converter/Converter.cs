using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    class Converter
    {
        double usd;
        double eur;
        double rub;
        double byn;

        public double Usd
        { get { return usd; } }
        public double Eur
        { get { return eur; } }
        public double Rub
        { get { return rub; } }
        public double Byn
        { get { return byn; } }
        public Converter (double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
            
        }

        public Converter (double byn)
        {
            this.byn = byn;
        }

        public double fromUsdToByn ()
        {
            return usd * 2;
        }

        public double fromEurToByn()
        {
            return eur * 2.5;
        }

        public double fromRubToByn()
        {
            return rub / 3.3;
        }

        public double fromBynToUsd()
        {
            return byn / 2;
        }

        public double fromBynToEur()
        {
            return byn / 2.5;
        }

        public double fromBynToRub()
        {
            return byn * 3.3;
        }



    }
}
