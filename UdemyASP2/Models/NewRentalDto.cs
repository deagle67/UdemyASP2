﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UdemyASP2.Models
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MoviesIds { get; set; }
    }
}