using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Personal
    {
        public int political { get; set; }
        public List<string> langs { get; set; }
        public string religion { get; set; }
        public string inspired_by { get; set; }
        public int people_main { get; set; }
        public int life_main { get; set; }
        public int smoking { get; set; }
        public int alcohol { get; set; }
    }
}
