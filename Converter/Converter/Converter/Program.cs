using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(100, 125, 6600);

            converter.Converter(100, Convertation.Usd, Convertation.Rub);

            //Console.WriteLine("{0} usd = {1} byn ",converter.Usd ,converter.fromUsdToByn());
            //Console.WriteLine("{0} eur = {1} byn ", converter.Eur, converter.fromEurToByn());
            //Console.WriteLine("{0} rub = {1} byn ", converter.Rub, converter.fromRubToByn());

            //Converter reversconvertor = new Converter(300);

            //Console.WriteLine(new string('-', 40));

            //Console.WriteLine("{0} byn = {1} usd",reversconvertor.Byn, reversconvertor.fromBynToUsd());
            //Console.WriteLine("{0} byn = {1} eur",reversconvertor.Byn, reversconvertor.fromBynToEur());
            //Console.WriteLine("{0} byn = {1} rub",reversconvertor.Byn, reversconvertor.fromBynToRub());

            
        }
    }
}
