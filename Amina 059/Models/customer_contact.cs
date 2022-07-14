using System.ComponentModel.DataAnnotations;

namespace Amina_059.Models
{
    public class customer_contact
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; }
    }
}
