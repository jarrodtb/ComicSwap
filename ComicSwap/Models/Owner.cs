using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ComicSwap.Models;

namespace ComicSwap
{
    public class Owner
    {
        [Key]
        public int OwnerID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Zip { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        ICollection<Comic> Comics;
    }
}