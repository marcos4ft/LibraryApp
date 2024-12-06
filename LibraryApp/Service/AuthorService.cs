using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Entities;

namespace LibraryApp.Service
{
    public class AuthorService: IService
    {

        public List<Author> Authors { get; set; } = [];

        public void Save(BaseEntity Author)
        {
            Authors.Add((Author)Author);
        }
    }
}
