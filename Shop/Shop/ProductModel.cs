using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ProductModel
    {
        public enum TypeProduct { Mouse,KeyBoard,Monitor,Laptop}
        public string Name { get; set; }
        public TypeProduct Type { get; set; }
        
        public ushort Price { get; set; }
        public ushort Amount { get; set; }
        public string PathToIMG { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"Category : {Type} Name : {Name} Amount : {Amount} ";
        }
    }
}
