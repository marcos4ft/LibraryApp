using LibraryApp.Entities;
using LibraryApp.Service;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryApp
{
    public class Program
    {

        public static void Main()
        {
            AuthorService AuthorService = new();
            ItemService ItemService = new();

            Author Author = new("Antonio");
            AuthorService.Save(Author);

            Book Book1 = new("Livro 1", 1, Author);
            Book Book2 = new("Livro 2", 2, Author);

            ItemService.Save(Book1);
            ItemService.Save(Book2);

            Author.Books.AddRange(ItemService.Books);

            Console.WriteLine("**************************");
            Console.WriteLine("*****    Atuhors     *****");
            Console.WriteLine("**************************");
            Author.Print();

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("**************************");
            Console.WriteLine("*****    Items     *****");
            Console.WriteLine("**************************");
            foreach (Item Book in ItemService.Books)
            {
                Book.Print();
            }



        }
    }
}