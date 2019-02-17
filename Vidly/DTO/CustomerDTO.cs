using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTO
{
    public class CustomerDTO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
               
        public int MembershipTypeID { get; set; }

        public MembershipTypeDTO MembershipType { get; set; }
        //[Min18Years]
        public DateTime? DateOfBirth { get; set; }
    }
}