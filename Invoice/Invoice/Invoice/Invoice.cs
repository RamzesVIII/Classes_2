using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    class Invoice
    {
        public readonly int account = 0;
        public readonly string customer = null;
        public readonly string provider = null;

        string article;
        int quantity;
        double price;

        public string Article { get; set; }
        public string Quantity { get; set; }

        public Invoice ( int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void ArticleCalculator (string Article, int Quantity)
        {
            
            switch (Article)
            {
                case "tv": price = 1500;
                    break;
                case "notebook": price = 2000;
                    break;
                case "mobile phone": price = 1000;
                    break;

                default:
                    Console.WriteLine("Такого товара нет в наличии.");
                    break;
            }
            Console.WriteLine("Сумма к оплате без НДС = {0}",price * Quantity);
            Console.WriteLine("Сумма к оплате с НДС = {0}", price * Quantity * 1.1);

        }


    }
}
