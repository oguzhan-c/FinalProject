﻿using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}