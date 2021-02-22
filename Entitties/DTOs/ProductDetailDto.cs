
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitties.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }


}
