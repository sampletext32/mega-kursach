using System.Dynamic;
using System.Net.Mime;

namespace Entities
{
    public class Art : AuditableEntity
    {
        public string PicPath { get; set; }

        public Album Album { get; set; }

        public Art(int id, string picPath, Album album) : base(id)
        {
            PicPath = picPath;
            Album = album;
        }
    }
}