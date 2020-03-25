using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GCS.Models
{
    [Table("company")]
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        [RegularExpression(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        public string Website { get; set; }
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Please enter in format (xxx) xxx-xxxx or xxx-xxx-xxxx.")]
        public string Phone { get; set; }
        public string Vision { get; set; }
        public string Mission { get; set; }
        public string Value { get; set; }
        public string Outcome { get; set; }
        public string Strategy { get; set; }
        public string Type { get; set; }
        public string Revenue_band { get; set; }
        public string Employee_band { get; set; }
        public string Stage { get; set; }
        public string KeyContact { get; set; }
    }
}
