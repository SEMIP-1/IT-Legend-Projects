using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library 
{ 
    class DVD : MediaItem
    {
        #region Properties
        public string Director { get; set; }
        public double RunningTime { get; set; }
        #endregion

        #region Constructors
        public DVD(string Title, Author Author, int PublishYear = 0, string Director = "", double RunningTime = 0)
            : base(Title, Author, PublishYear)
        {
            this.Director = Director;
            this.RunningTime = RunningTime;
        }
        #endregion
    }
}