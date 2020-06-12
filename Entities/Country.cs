using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Country(string title)
        {
            Title = title;
        }

        public Country()
        {
        }
    }
}