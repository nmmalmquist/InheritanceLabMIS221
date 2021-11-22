using System;

namespace mis221_lab_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", "jslucas@cba.ua.edu", 'm');
            Console.WriteLine(myAuthor.ToString());

            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());

            Console.WriteLine(myBook.GetAuthor().ToString());

            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", "jamie@mail.com", 'f'));
            Console.WriteLine(yourBook.ToString());

            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");


            Console.WriteLine(yourBook.ToString());

        }
    }
}
