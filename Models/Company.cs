using System.ComponentModel.DataAnnotations.Schema;

namespace GCS.Models
{
    [Table("company")]
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Vision { get; set; }
        public string Mission { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string Revenue_band { get; set; }
        public string Employee_band { get; set; }
        public string Stage { get; set; }
    }
}
