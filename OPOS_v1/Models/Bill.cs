using OpenPOS.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPOS.Models
{
    public class Bill : IBill
    {
        public int ID { get; set; }
        public DateTime Date {  get; set;  }
        public IUser User {  get; set;  }
        public List<KeyValuePair<int, IItem>> ItemCollection {  get; set;  }
        public decimal TotalPrice {  get; set;  }
        public int Discount {  get; set;  }
    }
}
