using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Follower
    {
        public int Id { get; set; }
        public int Sex { get; set; }
        public int City { get; set; }
        public int University { get; set; }
        public string Occupation { get; set; }

        public string Activities { get; set; }
        public int BirthDate { get; set; }

        public int Personal_political { get; set; }
        public string Personal_religion { get; set; }
        public int Personal_life_main { get; set; }
        public int Personal_people_main { get; set; }
        public int Military { get; set; } //unit_id
        public string Home_town { get; set; }
        public int Faculty { get; set; }

        public int Relation { get; set; }

        public Follower(int id, int sex, int city, int education, string occupation, string activities, int bdate, int personal_political, string personal_religion, int personal_life_main, int personal_people_main, int military, string home_town, int relation, int faculty)
        {
            Id = id;
            Sex = sex;
            City = city;
            University = education;
            Occupation = occupation;
            Activities = activities;
            BirthDate = bdate;
            Personal_political = personal_political;
            Personal_religion = personal_religion;
            Personal_life_main = personal_life_main;
            Personal_people_main = personal_people_main;
            Military = military;
            Home_town = home_town;
            Relation = relation;
            Faculty = faculty;
        }

        public Follower() {
            Id = 0;
            Sex = 0;
            City = 0;
            University = 0;
            Occupation = "";
            Activities = "";
            BirthDate = 0;
            Military = 0;
            Home_town = "";
            Relation = 0;
        }
    }


/*    public class City
    {
        public int id { get; set; }
        public string title { get; set; }
    }*/


/*    public class Military
    {
        public string unit { get; set; }
        public int unit_id { get; set; }
        public int country_id { get; set; }
        public int from { get; set; }
        public int until { get; set; }
    }*/

/*    public class Occupation
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }*/

    //public class Personal
    //{
       /* public int political { get; set; }
        public List<string> langs { get; set; }
        public string religion { get; set; }
        public string inspired_by { get; set; }
        public int people_main { get; set; }
        public int life_main { get; set; }
        public int smoking { get; set; }
        public int alcohol { get; set; }*/
       
    //}

    //public class Response
    //{
        /*public int id { get; set; }
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

        }*/

    //}





}









