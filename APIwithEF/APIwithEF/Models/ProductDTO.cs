﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIwithEF.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}