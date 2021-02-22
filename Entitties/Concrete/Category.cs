using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }
    }
  
}

