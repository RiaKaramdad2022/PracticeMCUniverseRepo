using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MCUniverse.Data;

namespace MCUniverse.Data.Entities
{
    public class StudentEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        public string Genger { get; set; } = null!;
        [Required]
        public string Address { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string OriginCountry { get; set; } = null!;
    }
}