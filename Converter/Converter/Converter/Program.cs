using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Converter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, BaseClass> language = new Dictionary<string, BaseClass>()
            {
                {"US", new Converter(2, 2.5, 0.033)},
                {"Rus", new ConverterRus(2, 2.5, 0.033)}
            };
            Console.WriteLine("Chose language : US or Rus.");
            string choselanguage = Console.ReadLine();
            
            language.TryGetValue(choselanguage, out var Lang);

            Lang.Convert(100, Curency.Byn, Curency.Usd);
            //try
            //{
            //    Converter converter = new Converter(0, 2.5, 0.033);

            //    converter.Convert(100, Curency.Usd, Curency.Rub);
            //}
            //catch
            //{
            //    //ignore

            //}


            
            //Console.WriteLine("{0} usd = {1} byn ",converter.Usd ,converter.fromUsdToByn());
            //Console.WriteLine("{0} eur = {1} byn ", converter.Eur, converter.fromEurToByn());
            //Console.WriteLine("{0} rub = {1} byn ", converter.Rub, converter.fromRubToByn());

            //Converter reversconvertor = new Converter(300);

            //Console.WriteLine(new string('-', 40));

            //Console.WriteLine("{0} byn = {1} usd",reversconvertor.Byn, reversconvertor.fromBynToUsd());
            //Console.WriteLine("{0} byn = {1} eur",reversconvertor.Byn, reversconvertor.fromBynToEur());
            //Console.WriteLine("{0} byn = {1} rub",reversconvertor.Byn, reversconvertor.fromBynToRub());

            Console.ReadKey();
        }
    }
}
