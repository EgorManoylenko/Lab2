using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._3
{
    public class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine($"Title: {title}");
        }
    }

    public class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine($"Author: {author}");
        }
    }

    public class Content
    {
        private string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine($"Content: {content}");
        }
    }

    public class Book
    {
        private Title title = null;
        private Author author = null;
        private Content content = null;

        public void AddTitle(string title)
        {
            this.title = new Title(title);
        }

        public void AddAuthor(string author)
        {
            this.author = new Author(author);
        }

        public void AddContent(string content)
        {
            this.content = new Content(content);
        }

        public void Show()
        {
            Console.WriteLine("Book:");

            ConsoleColor initialColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            title?.Show();

            Console.ForegroundColor = ConsoleColor.Green;
            author?.Show();

            Console.ForegroundColor = ConsoleColor.Blue;
            content?.Show();

            Console.ForegroundColor = initialColor;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding =
                Console.OutputEncoding =
                    Encoding.Unicode;

            var book = new Book();

            while (true)
            {
                Console.WriteLine("Що ви хочете змінити?");
                Console.WriteLine("1. Змінити назву");
                Console.WriteLine("2. Змінити автора");
                Console.WriteLine("3. Змінити зміст");
                Console.WriteLine("4. Показати книжку");
                Console.WriteLine("5. Закрити");
                Console.Write("Ваш вибір: ");
                int ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 1)
                {
                    Console.Write("Введіть назву книжки: ");
                    book.AddTitle(Console.ReadLine());
                }
                if (ch == 2)
                {
                    Console.Write("Введіть автора книжки: ");
                    book.AddAuthor(Console.ReadLine());
                }
                if (ch == 3)
                {
                    Console.Write("Введіть зміст книжки: ");
                    book.AddContent(Console.ReadLine());
                }
                if (ch == 4)
                {
                    book.Show();
                }
                if (ch == 5)
                {
                    break;
                }
                if (ch < 1 || ch > 5)
                {
                    Console.WriteLine("Вибір не правильний");
                }
            }
        }
    }
}