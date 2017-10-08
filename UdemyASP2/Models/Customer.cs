using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UdemyASP2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MemberShipType MemberShipType { get; set; }
        public byte MemberShipTypeId { get; set; }
    }
}