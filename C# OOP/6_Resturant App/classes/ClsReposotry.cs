using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_App.Classes
{
    public interface ClsReposotry<t> where t : class
    {
        public void Add<t>();
        public void Edit<t>();
        public void Delete<t>();
        public void GetAll<t>();
    }
}