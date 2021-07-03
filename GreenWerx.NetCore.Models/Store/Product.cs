using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenWerx.NetCore.Models.Store
{
    //[Table("Products")]
    public class Product : Item
    {
        public Product()
        {
            UUIDType = "Product";
        }

        public string Link { get; set; }

        public string LinkProperties { get; set; }

      
        public string StrainUUID { get; set; }
    }
}
