using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities
{
    public abstract class Item(string Title, int Edition):BaseEntity
    {
        public string Title { get; set; } = Title;
        public int Edition { get; set; } = Edition;

    }
}
