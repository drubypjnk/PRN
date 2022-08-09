using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace project.Logics
{
    public class CategoryManager
    {

        public CategoryManager()
        {
        }
        public List<Category> getCategories()
        {
            using (var context =new Shop_PRNContext())
            {
                return context.Categories.ToList();
            }
        }
        public List<Category> GetCategory(int id)
        {
            using (var context = new Shop_PRNContext())
            {
            if(id == 0)
                {
                    return context.Categories.ToList();
                }
                else
                {
                    return context.Categories.Where(x=>x.CategoryId == id).ToList();    
                }
            }

        }

       
    }
}
