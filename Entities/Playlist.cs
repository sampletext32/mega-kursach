using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Playlist
    {
        public int Id { get; set; }
        public Art Art { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Playlist(Art art, string title, string description)
        {
            Art = art;
            Title = title;
            Description = description;
        }

        public Playlist()
        {
        }
    }
}