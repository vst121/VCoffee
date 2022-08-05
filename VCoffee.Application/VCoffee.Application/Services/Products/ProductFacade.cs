using VCoffee.Application.Interfaces.Contexts;
using VCoffee.Application.Interfaces.FacadPatterns;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCoffee.Domain.Entities.Products;

namespace VCoffee.Application.Services.Products.FacadPattern
{
    public class ProductFacade : IProductFacade
    {
        private readonly IDataBaseContext _context;
        public ProductFacade(IDataBaseContext context)
        {
            _context = context;

        }

        public bool AddNewProduct => throw new System.NotImplementedException();

        public IEnumerable<Product> GetAllProducts => throw new System.NotImplementedException();
    }
}
