using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Military
    {
        public string unit { get; set; }
        public int unit_id { get; set; }
        public int country_id { get; set; }
        public int from { get; set; }
        public int until { get; set; }
    }
}
