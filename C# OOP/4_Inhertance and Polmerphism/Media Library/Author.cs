using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library
{
    class Author
    {

        #region Properties
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        #endregion

        #region Methods
        public void Add()
        {
            Console.WriteLine("Adding a new author");
        }
        public void Edit()
        {
            Console.WriteLine("Editing an author");
        }
        public void Delete()
        {
            Console.WriteLine("Deleting an author");
        } 
        #endregion
    }
}