using project.Models;
using System.Collections.Generic;
using System.Linq;

namespace project.Logics
{
    public class ProductManager
    {

        public ProductManager()
        {
        }

        public List<Product> GetProductsByCategory(int categoryID)
        {  using(var context = new Shop_PRNContext())
            {
                if (categoryID == 0)
                {
                    return context.Products.ToList();
                }
                else
                {
                    return context.Products.Where(x=>x.CategoryId== categoryID).ToList();
                }     

            }

        }
        public Product GetProductByID(int id)
        {
            using (var context = new Shop_PRNContext())
            {
                return context.Products.FirstOrDefault(x=>x.ProductId==id);
            }
        }

    }
}
