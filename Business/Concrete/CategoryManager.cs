using Core.Utilities.Results;
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

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(categoryDal.GetAll());
        }

        public IDataResult<List<Category>> GetByCategoryName(int min, int max)
        {
            return new SuccessDataResult<List<Category>>(categoryDal.GetAll(c => c.CategoryName.Length >= min && c.CategoryName.Length <= max));
        }
    }
}
