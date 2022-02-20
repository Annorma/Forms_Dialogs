using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Dialogs
{
    public class Product
    {
        public string Name { get; set; }
        public DateTime ProductDate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Product {Name} {Price}${Environment.NewLine}" +
                   $"Date: {ProductDate}{Environment.NewLine}" +
                   $"Description: {Description}";
        }
    }
}
