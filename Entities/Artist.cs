using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Artist : User
    {
        public Artist(int id, string title) : base(id, title)
        {
        }
    }
}