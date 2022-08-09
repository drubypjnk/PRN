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
  
        public List<Product> GetProducts()
        {
            using (var context = new Shop_PRNContext())
            {
                return context.Products.ToList();
            }
        }
        public Product GetProductByID(int id)
        {
            using (var context = new Shop_PRNContext())
            {
                return context.Products.FirstOrDefault(x=>x.ProductId==id);
            }
        }
        public List<Product> filter(int id,string word,int sortID)
        {
            List<Product> products = new List<Product>();
            products=GetProductsByCategory(id);
             switch (sortID)
            {
                case 0:
                    break;
                case 1:
                    products.Sort((a,b)=>decimal.Compare((decimal)a.SalePrice,(decimal)b.SalePrice));
                    break;
                     case 2:
                    products.Sort((a,b)=>-decimal.Compare((decimal)a.SalePrice,(decimal)b.SalePrice));
                    break;
            }
            if (word != null)
            {
              products=products.Where(x => x.ProductName.Contains(word)).ToList();
            }
            return products;
        }
        public void UpdateProduct(Product p)
        {
            using (var context = new Shop_PRNContext())
            {
               Product product=context.Products.FirstOrDefault(x => x.ProductId==p.ProductId);
                product.ProductName=p.ProductName;
                product.SalePrice = p.SalePrice;
                product.OriginalPrice = p.OriginalPrice;
                product.Origin = p.Origin;
                product.Feature = p.Feature;
                product.Describe = p.Describe;
                product.Brand = p.Brand;
                product.CategoryId = p.CategoryId;
                product.Thumbnail = p.Thumbnail;
                product.UnitInStock = p.UnitInStock;
                product.UnitOnOrder = p.UnitOnOrder;
                context.SaveChanges();
            }
        }
        public void HideProduct(int product_id)
        {
            using (var context = new Shop_PRNContext())
            {
              Product product= context.Products.FirstOrDefault(x => x.ProductId == product_id);
                product.Feature = false;
                context.SaveChanges();
            }
        }

        public void Addproduct(Product product)
        {
            using (var context = new Shop_PRNContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
