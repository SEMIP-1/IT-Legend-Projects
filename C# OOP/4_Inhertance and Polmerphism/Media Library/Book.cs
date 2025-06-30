using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library
{
    class Book : MediaItem
    {
        #region Properties
        public int NumPages { get; set; }
        #endregion

        #region Constructors
        public Book(string Title, Author Author, int PublishYear = 0, int NumPages = 0)
            : base(Title, Author, PublishYear)
        {
            this.NumPages = NumPages;
        }
        #endregion
    }
}