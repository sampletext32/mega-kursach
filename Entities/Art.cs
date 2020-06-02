using System.Dynamic;
using System.Net.Mime;

namespace Entities
{
    public class Art : AuditableEntity
    {
        public string PicPath { get; set; }

        public Art(int id, string picPath) : base(id)
        {
            PicPath = picPath;
        }

        public Art()
        {
        }
    }
}