using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyInventoryTest.Model
{
    public class Inventory
    {
        public long InventoryID { get; set; }
        public string CategoryName { get; set; }
        public string DescriptionName { get; set; }
        public long QtyNeeded { get; set; }
        public long QtyLeftOver { get; set; }
    }
}
