using Entities;
using System;
using System.Collections.Generic;

namespace Business.Constans
{
    //Static verildiğinde new leme gerekmez direkt messages. dendiğinde kullanılabilir
    public static class Messages
    {
        //private olduğunda camel case yazılır yani kelimenin ilk harfi küçük diğer kelimenin harfi büyük
        //public olanlar pascal case il yazılır yani kelimenin ilk harfi büyük gerisi küçük başkabir kelime gelirse gene ilk harf büyük gerisi küçük
        public static String ProductAdded = "Product Added" ;
        public static string ProductNameInvalid = "Product Name Invaled ";
        public static String MaintenanceTime = "System overhaul ";
        public static string ProducstListed = "Products Listed";
    }
}
