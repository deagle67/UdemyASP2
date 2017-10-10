﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DateTime? BirthDate { get; set; }

        [Display(Name = "MemberShip Type")]
        public byte MemberShipTypeId { get; set; }
    }
}