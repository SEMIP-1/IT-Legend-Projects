using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library
{
    class AudioBook : MediaItem
    {
        #region Properties
        double TrackLenght { get; set; }
        #endregion

        #region Constructors
        public AudioBook(string Title, Author Author, int PublishYear = 0, double TrackLenght = 0)
            : base(Title, Author, PublishYear)
        {
            this.TrackLenght = TrackLenght;
        }
        #endregion
    }
}