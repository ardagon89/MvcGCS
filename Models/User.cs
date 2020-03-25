using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCS.Models
{
    [Table("user")]
    public class User
    {
        public int Id { get; set; }
        public int Company_id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Please enter in format (xxx) xxx-xxxx or xxx-xxx-xxxx.")]
        public string Phone { get; set; }
        [RegularExpression(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        public string Password { get; set; }
        public Boolean Is_admin { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Role { get; set; }
        public string Company_length { get; set; }
        public string Role_length { get; set; }
    }
}
