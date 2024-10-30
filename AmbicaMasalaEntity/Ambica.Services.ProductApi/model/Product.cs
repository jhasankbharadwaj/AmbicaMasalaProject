﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Ambica.Services.ProductApi.model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool Availability { get; set; }
    }
}
