using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._8
{
    public class Invoice
    {
        public int Account { get; }
        public string Customer { get; }
        public string Provider { get; }

        private string article;
        private int quantity;

        public Invoice(
            int account,
            string customer,
            string provider,
            string article,
            int quantity
        )
        {
            Account = account;
            Customer = customer;
            Provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        public double CalculateCost(bool includeVat)
        {
            double price = 0d;

            switch (article)
            {
                case "709543975370":
                    price = 20d;
                    break;

                case "256053730278":
                    price = 55d;
                    break;

                case "535960719906":
                    price = 145d;
                    break;
            }

            return price * quantity / (includeVat ? 0.8d : 1d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding =
    Console.OutputEncoding =
        System.Text.Encoding.Unicode;

            var invoice = new Invoice(
                account: 1350,
                customer: "John Doe",
                provider: "Apple",
                article: "535960719906",
                quantity: 10
            );

            Console.WriteLine(
                $"Сума оплати без НДС: {invoice.CalculateCost(false)} грн."
            );
            Console.WriteLine(
                $"Сума оплати с НДС: {invoice.CalculateCost(true)} грн."
            );

            Console.ReadLine();

        }
    }
}
