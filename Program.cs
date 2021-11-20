using System;

namespace Composition_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Author myAuthor = new Author("Dustin Savage", 'm', "dnsavage@crimson.ua.edu");
            Console.WriteLine(myAuthor.ToString() + "\n");

            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString() + "\n");

            Console.WriteLine(myBook.GetAuthor().ToString() + "\n");

            Book yourBook = new Book("1997", "A Transparent Book", new Author("jamie", 'f', "jamie@mail.com"));
            Console.WriteLine(yourBook.ToString());

            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");

            Console.WriteLine(yourBook.ToString());
        }
    }
}
