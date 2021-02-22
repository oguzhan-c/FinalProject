using Core.DataAcces.EntityFramework;
using DataAcces.Abstruct;
using Entities;
using Entitties.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Concrete.EntityFremavork
{
    public class EFProductDal : EFEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
       
    
