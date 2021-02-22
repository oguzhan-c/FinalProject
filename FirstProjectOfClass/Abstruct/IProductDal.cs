using Core.DataAcces.EntityFramework;
using Entities;
using Entitties.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstruct
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
