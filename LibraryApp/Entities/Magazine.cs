using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities
{
    public class Magazine(string Title, int Edition) : Item(Title, Edition)
    {
        public override void Print()
        {
            Console.WriteLine("*** Magazine ***");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Edition: " + Edition);
        }
    }
}
