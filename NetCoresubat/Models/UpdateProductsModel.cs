﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Models
{
    public class UpdateProductsModel
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Name area connot be null.!")]
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        // public IFormFile ProductPicture { get; set; }
    }
}
