using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library
{
    class MediaItem
    {
        #region Properties
        public int ID { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }
        public Author Author { get; set; }
        bool IsAvailable { get; set; }
        #endregion

        #region Constractors
        public MediaItem(string Title, Author Author, int PublishYear=0)
        {
            this.Title = Title;
            this.Author = new Author();
            this.PublishYear = PublishYear;
            this.IsAvailable = true;//default value
        }
        #endregion

        #region Methods
        public void Create()
        {
            Console.WriteLine("Creating a new media item");
        }
        public void Edit()
        {
            Console.WriteLine("Creating a new media item");
        }
        public void Delete()
        {
            Console.WriteLine("Creating a new media item");
        }
        #endregion
    }
}