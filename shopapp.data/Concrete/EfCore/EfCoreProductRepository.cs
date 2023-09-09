using System.Collections.Generic;
using shopapp.data.Abstract;
using shopapp
namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : 
    EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            using (var context = new ShopContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetTop5Products()
        {
            throw new System.NotImplementedException();
        }
    }
}