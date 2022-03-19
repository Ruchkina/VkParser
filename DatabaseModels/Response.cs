using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Response
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool can_access_closed { get; set; }
        public bool is_closed { get; set; }
        public int sex { get; set; }
        public string bdate { get; set; }
        public City city { get; set; }
        public string activities { get; set; }
        public Occupation occupation { get; set; }
        public Personal personal { get; set; }
        public int university { get; set; }
        public string university_name { get; set; }
        public int faculty { get; set; }
        public string faculty_name { get; set; }
        public string home_town { get; set; }
        public int graduation { get; set; }
        public int relation { get; set; }
        public Military military { get; set; }

        public Response()
        {
            occupation = new Occupation();
            city = new City();
            personal = new Personal();
            military = new Military();

        }
    }
}
