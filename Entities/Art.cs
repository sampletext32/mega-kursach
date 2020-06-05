using System.Dynamic;
using System.Net.Mime;

namespace Entities
{
    public class Art : AuditableEntity
    {
        public string PicPath { get; set; }

        public Art(string picPath)
        {
            PicPath = picPath;
        }

        public Art()
        {
        }
    }
}