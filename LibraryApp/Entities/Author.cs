using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities
{
    public class Author(string Name):BaseEntity
    {
        public string Name { get; set; } = Name;
        public List<Book> Books { get; set; } = [];

        public override void Print()
        {
            Console.WriteLine("*** Author ***");
            Console.WriteLine("Title: " + Name);
            Console.WriteLine("     Boos    ");
            foreach (Book Book in Books)
            {
                Book.Print();
            }
        }
    }
}
