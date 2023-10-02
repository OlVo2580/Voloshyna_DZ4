using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voloshyna_DZ44_5
{
    public class Goods : Product
    {
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }

    }
}
