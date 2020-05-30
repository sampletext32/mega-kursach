using System.Dynamic;
using System.Net.Mime;

namespace Entities
{
    public class Art : AuditableEntity
    {
        public string PicPath { get; set; }
        public int AlbumId { get; set; }

        public Art(int id, string picPath, int albumId) : base(id)
        {
            PicPath = picPath;
            AlbumId = albumId;
        }
    }
}