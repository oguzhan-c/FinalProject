using DataAcces.Abstruct;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }

        public List<Category> GetByCategoryName(int min, int max)
        {
            return categoryDal.GetAll(c => c.CategoryName.Length >= min && c.CategoryName.Length <= max);
        }
    }
}
