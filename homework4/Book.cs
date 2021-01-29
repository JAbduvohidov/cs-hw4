using System;

namespace homework4
{
    public class Book
    {
        public readonly Title Title;
        public readonly Author Author;
        public readonly Content Content;

        public Book(string title, string author, string content)
        {
            Title = new Title(title);
            Author = new Author(author);
            Content = new Content(content);
        }

        public void Show()
        {
            Title.Show(ConsoleColor.Red);
            Author.Show(ConsoleColor.Yellow);
            Content.Show(ConsoleColor.Green);
        }
    }

    public class Title
    {
        private readonly string _value;

        public Title(string value)
        {
            _value = value;
        }

        public void Show(ConsoleColor color)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(_value);
            Console.ForegroundColor = currentColor;
        }
    }

    public class Author
    {
        private readonly string _value;

        public Author(string value)
        {
            _value = value;
        }

        public void Show(ConsoleColor color)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(_value);
            Console.ForegroundColor = currentColor;
        }
    }

    public class Content
    {
        private readonly string _value;

        public Content(string value)
        {
            _value = value;
        }

        public void Show(ConsoleColor color)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(_value);
            Console.ForegroundColor = currentColor;
        }
    }
}