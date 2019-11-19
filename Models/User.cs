using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCS.Models
{
    [Table("user")]
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Company ID")]
        public int Company_id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
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
