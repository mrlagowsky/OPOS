using OpenPOS.Interface;

namespace OpenPOS.Models
{
    public class Item : IItem
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
