using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedtonewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }
        [Display(Name= "MemberShip Type")]
        public byte MembershipTypeId { get; set; }

        [Display (Name = "Date Of Birth")]
        public DateTime? DOB { get; set; }
    }
}