using Core.DataAcces.EntityFramework;
using DataAcces.Abstruct;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Concrete.EntityFremavork
{
    class EFOrderDal : EFEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
   
    }
}
