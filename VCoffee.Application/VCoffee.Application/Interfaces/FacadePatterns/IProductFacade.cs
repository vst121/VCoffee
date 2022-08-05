using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCoffee.Domain.Entities.Products;

namespace VCoffee.Application.Interfaces.FacadPatterns
{
    public interface IProductFacade
    {
        bool AddNewProduct { get; }
        IEnumerable<Product> GetAllProducts { get; }
    }
}
