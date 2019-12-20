using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public enum Curenci
    {
        Usd ,
        Eur ,
        Rub ,
        Byn 
    }
    public class BaseClass
    {

        private readonly Dictionary<Curenci, double> CurenciValue;
        public BaseClass(double usd, double eur, double rub)
        {
            CurenciValue = new Dictionary<Curenci, double>
            {
               {Curenci.Usd, usd },
               {Curenci.Eur, eur },
               {Curenci.Rub, rub },
               {Curenci.Byn, 1 }
            };
        }

       
        public virtual void Converter(double money, Curenci cur1, Curenci cur2)
        {

            try
            {
                double koef1, koef2;
                CurenciValue.TryGetValue(cur1, out koef1);
                CurenciValue.TryGetValue(cur2, out koef2);
                if (koef1 == 0 || koef2 == 0)
                {
                    throw new Exception("Курс для данной валюты не установлен, или установлен в 0, желаете продолжить : Y/N?");
                }
                double sum = money * koef1 / koef2;
                Console.WriteLine(sum);

            
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
