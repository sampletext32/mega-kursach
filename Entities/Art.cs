using System.Dynamic;
using System.Net.Mime;

namespace Entities
{
    public class Art
    {
        public int Id { get; set; }
        public string PicPath { get; set; }

        public Art(int id, string picPath)
        {
            Id = id;
            PicPath = picPath;
        }
    }
}