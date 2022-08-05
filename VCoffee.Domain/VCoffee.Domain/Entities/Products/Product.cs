using System;
using System.ComponentModel.DataAnnotations;
using VCoffee.Domain.Entities.Commons;

namespace VCoffee.Domain.Entities.Products
{
    public class Product : BaseEntity {
        [MaxLength(64)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [MaxLength(128)]
        public string Description { get; set; }

    }
}