using DatabaseModels;
using System.Collections.Generic;
using System.Linq;


namespace Core
{
    public static class ConvertBirth
    {
        public static int GetBirthYear(Response unvalidUserInfo)
        {
            int year = 0;
            List<string> birth = new List<string>(unvalidUserInfo.bdate.Split('.'));
            if (birth.Count() == 3)
                year = int.Parse(birth.Last());
            return year;
        }
    }
}
