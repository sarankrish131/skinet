
using core.Entities;

namespace core.Specification
{
    public class ProductWithTypesAndBrandSpecification : BaseSpecification<Product>
    {
        public ProductWithTypesAndBrandSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        public ProductWithTypesAndBrandSpecification(int id)
        :base(x=>x.Id == id)
        {
             AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);

        }
    }
}