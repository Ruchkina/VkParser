using DatabaseModels;


namespace Core
{
    public static class ConvertToValidFollowers
    {
        public static Follower? Convert(Response UserInfo)
        {
            if (UserInfo == null)
                return null;

            return new Follower(
                id : UserInfo.id,
                sex: UserInfo.sex,
                city : UserInfo.city.id,
                education : UserInfo.university,
                occupation : UserInfo.occupation.type,
                activities : UserInfo.activities,
                bdate: ConvertBirth.GetBirthYear(UserInfo),
                personal_political : UserInfo.personal.political,
                personal_religion : UserInfo.personal.religion,
                personal_life_main : UserInfo.personal.life_main,
                personal_people_main : UserInfo.personal.people_main,
                military : UserInfo.military.unit_id,
                home_town : UserInfo.home_town,
                relation : UserInfo.relation,
                faculty : UserInfo.faculty
            );
        }
    }
}
