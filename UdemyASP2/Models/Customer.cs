using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UdemyASP2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MemberShipType MemberShipType { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfMember]
        [Column(TypeName = "datetime2")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "MemberShip Type")]
        public byte? MemberShipTypeId { get; set; }
    }
}