using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
    public enum Category {Dairy=0,Bakery,Confectionary}
    public class Product
    {
        public Category CategoryProduct { get; set; }
        public string Name { get; set; }
        public int Quentity { get; set; }
        public int Price { get; set; }

    }
}
