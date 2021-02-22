using Core.DataAcces.EntityFramework;
using DataAcces.Abstruct;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete.EntityFremavork
{
    public class EFCustomerDal: EFEntityRepositoryBase<Customer,NorthwindContext>,ICustomerDal
    {
    }
}
