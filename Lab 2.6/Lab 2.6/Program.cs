using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._6
{
    public class Converter
    {
        public double UsdToUah { get; set; }

        public double EurToUah { get; set; }

        public double RubToUah { get; set; }

        public Converter(double usd, double eur, double rub)
        {
            UsdToUah = usd;
            EurToUah = eur;
            RubToUah = rub;
        }

        public double ConvertToUsd(double uah)
        {
            return uah * UsdToUah;
        }

        public double ConvertToEur(double uah)
        {
            return uah * EurToUah;
        }

        public double ConvertToRub(double uah)
        {
            return uah * RubToUah;
        }

        public double ConvertFromUsd(double usd)
        {
            return usd / UsdToUah;
        }

        public double ConvertFromEur(double eur)
        {
            return eur / EurToUah;
        }

        public double ConvertFromRub(double rub)
        {
            return rub / RubToUah;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding =
                Console.OutputEncoding =
                    System.Text.Encoding.Unicode;

            var converter = new Converter(
                usd: 1d / 26.69d,
                eur: 1d / 34.3d,
                rub: 1d / 0.37d
            );

            Console.WriteLine("Варіанти конвертації:");
            Console.WriteLine("1. USD -> UAH");
            Console.WriteLine("2. EUR -> UAH");
            Console.WriteLine("3. RUB -> UAH");
            Console.WriteLine("4. UAH -> USD");
            Console.WriteLine("5. UAH -> EUR");
            Console.WriteLine("6. UAH -> RUB");
            Console.WriteLine();

            Console.Write("Ваш вибір: ");
            int choice;
            bool choiceParsed = int.TryParse(Console.ReadLine(), out choice);

            if (!choiceParsed)
            {
                Console.WriteLine("Недопустимий вибір");
                Console.ReadLine();
                return;
            }

            Console.Write("Кількість одиниць валюти: ");
            double value;
            bool valueParsed = double.TryParse(Console.ReadLine(), out value);

            if (!valueParsed)
            {
                Console.WriteLine("Недопустиме значення");
                Console.ReadLine();
                return;
            }

            Console.Write("Результат: ");

            switch (choice)
            {
                // USD -> UAH
                case 1:
                    Console.WriteLine(converter.ConvertFromUsd(value));
                    break;

                // EUR -> UAH
                case 2:
                    Console.WriteLine(converter.ConvertFromEur(value));
                    break;

                // RUB -> UAH
                case 3:
                    Console.WriteLine(converter.ConvertFromRub(value));
                    break;

                // UAH -> USD
                case 4:
                    Console.WriteLine(converter.ConvertToUsd(value));
                    break;

                // UAH -> EUR
                case 5:
                    Console.WriteLine(converter.ConvertToEur(value));
                    break;

                // UAH -> RUB
                case 6:
                    Console.WriteLine(converter.ConvertToRub(value));
                    break;

                default:
                    Console.WriteLine("-");
                    Console.WriteLine("Така конвертація не підтримується");
                    break;
            }

            Console.ReadLine();
        }
    }
}
