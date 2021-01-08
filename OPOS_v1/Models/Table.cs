using OpenPOS.Interface;

namespace OpenPOS.Models
{
    public class Table : ITable
    {
        public int ID { get; set; }

        public IBill ItemSummary { get; set; }

        public bool Available { get; set; }
    }
}
