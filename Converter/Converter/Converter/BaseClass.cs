using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public enum Curency
    {
        Usd ,
        Eur ,
        Rub ,
        Byn 
    }
    public class BaseClass
    {
        
        private readonly Dictionary<Curency, double> CurenciValue;
        public BaseClass(double usd, double eur, double rub)
        {
            CurenciValue = new Dictionary<Curency, double>
            {
               {Curency.Usd, usd },
               {Curency.Eur, eur },
               {Curency.Rub, rub },
               {Curency.Byn, 1 }
            };
            
        }

       
        public virtual double Convert(double money, Curency cur1, Curency cur2)
        {
            
            try
            {

                CurenciValue.TryGetValue(cur1, out var koef1);
                CurenciValue.TryGetValue(cur2, out var koef2);
                if (koef1 == 0 || koef2 == 0)
                {
                    throw new Exception("Курс для данной валюты не установлен, или установлен в 0, желаете продолжить : Y/N?");
                }
                return money * koef1 / koef2;
            }
            catch /*(Exception e)*/
            {
                //Console.WriteLine(e.Message);
                throw;
            }
            
        }
    }
}
