using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Genre(string title)
        {
            Title = title;
        }

        public Genre()
        {
        }
    }
}