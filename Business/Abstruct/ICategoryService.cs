using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetByCategoryName(int min, int max);
    }
}
