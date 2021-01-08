using OpenPOS.Interface;

namespace OpenPOS.Models
{
    public class User : IUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
    }
}
