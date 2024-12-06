using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Entities;

namespace LibraryApp.Service
{
    public interface IService
    {

        void Save(BaseEntity Entity);
    }
}
