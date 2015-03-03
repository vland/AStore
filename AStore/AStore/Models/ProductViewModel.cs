﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AStore.Data;

namespace AStore.Models
{
    public class ProductViewModel
    {
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; } 
    }
}