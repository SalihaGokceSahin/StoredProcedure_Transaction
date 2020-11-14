using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Customer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string UserSession { get; set; }
    }
}
