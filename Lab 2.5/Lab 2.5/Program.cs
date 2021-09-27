using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._5
{

    public class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public DateTime FormFillingDate { get; }

        public User(
            string login, string firstName, string secondName,
            int age)

        {
            Login = login;
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            FormFillingDate = DateTime.Now;
        }

        public override string ToString()
        {
            return
                $"Логін: {Login}\n" +
                $"Ім'я: {FirstName}\n" +
                $"Призвіще: {SecondName}\n" +
                $"Вік: {Age}\n" +
                $"Дата заповнення анкети: {FormFillingDate}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = 
                Console.OutputEncoding = 
                    System.Text.Encoding.Unicode;

            Console.Write("Логін: ");
            string login = Console.ReadLine();

            Console.Write("Ім'я: ");
            string firstName = Console.ReadLine();

            Console.Write("Призвіще: ");
            string secondName = Console.ReadLine();

            Console.Write("Вік: ");
            int age = int.Parse(Console.ReadLine());

            var user = new User(
                login,
                firstName,
                secondName,
                age
            );

            Console.WriteLine();
            Console.WriteLine("Ваша заповнена анкета:");
            Console.WriteLine(user);

            Console.ReadLine();
        }
    }
}
