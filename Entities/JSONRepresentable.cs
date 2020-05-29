namespace Entities
{
    public class JSONRepresentable
    {
        public string AsJSON { get; set; }
        public JSONRepresentable FromJSON { get; set; }
    }
}