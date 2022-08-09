using project.Logics;
using System.Collections.Generic;

namespace project.Models
{
    public class Cart
    {
        public List<Item> items;
      
        public Cart()
        {
            items = new List<Item>(); 
        }
        public int GetQuantityByID(int id)
        {
            return GetItemById(id).quantity;
        }
        public void addItem(Item t)
        {
            if (GetItemById(t.Product.ProductId) != null)
            {
                Item m = GetItemById(t.Product.ProductId);
                m.quantity=(m.quantity + t.quantity);
               
            }
            else
            {
                items.Add(t);
            }
        }
        private Item GetItemById(int id)
        {
            foreach (Item i in items)
            {
                if (i.Product.ProductId == id)
                {
                    return i;
                }
            }
            return null;
        }
        public double GetTotalMoney()
        {
            double totalMoney = 0;
            foreach (Item i in items)
            {
                totalMoney += i.quantity * i.price;
            }
            return totalMoney;
        }
        public void refresh()
        {
            ProductManager productManager = new ProductManager();
           
            foreach (Item i in items)
            {
                Product p=productManager.GetProductByID(i.Product.ProductId);
                i.Product = p;
            }
        }

    public void RemoveItem(int id)
    {
        if (GetItemById(id) != null)
        {
            items.Remove(GetItemById(id));
        }
    }
        private Product getProductById(int id, List<Product> list)
        {
            foreach (Product i in list)
            {
                if (i.ProductId == id)
                {
                    return i;
                }
            }
            return null;
        }

    }
}
