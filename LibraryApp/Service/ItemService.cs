using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Entities;

namespace LibraryApp.Service
{
    public class ItemService : IService
    {

        public List<Book> Books { get; set; } = [];
        public List<Magazine> Magazines { get; set; } = [];

        public void Save(BaseEntity Item)
        {
            if (Item is Book Book)
            {
                Books.Add(Book);
            }else if(Item is Magazine Magazine)
            {
                Magazines.Add(Magazine);
            }
            
        }
    }
}
