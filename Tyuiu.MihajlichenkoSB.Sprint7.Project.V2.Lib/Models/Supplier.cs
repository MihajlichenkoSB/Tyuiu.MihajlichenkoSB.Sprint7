using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Lib.Models
{
    internal class Supplier
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal DeliveryCost { get; set; }

    }
}
