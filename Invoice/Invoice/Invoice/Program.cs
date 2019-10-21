using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice notebook = new Invoice(8888, "amd", "velcome");
            notebook.ArticleCalculator("notebook", 8);
        }
    }
}
