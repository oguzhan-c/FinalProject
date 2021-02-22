using Core.DataAcces.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstruct
{
    public interface IOrderDal : IEntityRepository<Order>
    {
    }
}
