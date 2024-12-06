using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities
{
    public class Book(string Title, int Edition, Author Author) : Item(Title, Edition)
    {

        public Author Author { get; set; } = Author;

        public override void Print()
        {
            Console.WriteLine("*** Book ***");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Edition: " + Edition);
            Console.WriteLine("Author: " + Author.Name);
        }
    }
}
