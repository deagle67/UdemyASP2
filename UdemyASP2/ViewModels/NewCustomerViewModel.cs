using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdemyASP2.Models;

namespace UdemyASP2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}