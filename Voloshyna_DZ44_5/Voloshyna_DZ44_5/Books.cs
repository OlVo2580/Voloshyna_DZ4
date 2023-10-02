using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voloshyna_DZ44_5
{
    public class Books : Product
    {
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public List<string> Authors { get; set; }
    }
}
