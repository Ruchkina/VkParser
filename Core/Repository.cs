using DatabaseContext;
using DatabaseModels;
using Extractor1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public class Repository
    {
        private DatabaseContexts Context;
        private Extractor extractor;
        private Response UnvalidUserInfo;
        private Follower follower;
        private string nameParty;
        private List<string> idUsers;
        private string idGroupParty;
        private int idParty;

        public Repository(DatabaseContexts context,  string name, string idGroup)
        {
            Context = context;
            extractor = new Extractor();        
            follower = new Follower();
            idUsers = new List<string>();
            nameParty = name;
            idGroupParty = idGroup;
        }

        public async Task GetParty()
        {
            idUsers = await extractor.FetchInfoGroup(idGroupParty);
            await AddParty();
        }

        public async Task GetAllUserInfo()
        {
            foreach (string id in idUsers)
            {
                UnvalidUserInfo = await extractor.FetchInfoUser(int.Parse(id));
                if ((UnvalidUserInfo.bdate != null && UnvalidUserInfo.sex != 0 && !(Context.Follower.Any(s => s.Id == UnvalidUserInfo.id)) && GetBirthYear() != 0))
                {
                    follower = DoValidFollowers(UnvalidUserInfo);
                    await AddFollower(follower);
                    await AddSubscription(follower.Id, idParty);
                }
                
            }
        }

        public Follower DoValidFollowers(Response UserInfo)
        {
            Follower ValidUnfo = new Follower();
            ValidUnfo.Id = UserInfo.id;
            ValidUnfo.Sex = UserInfo.sex;
            ValidUnfo.City = UserInfo.city.id;
            ValidUnfo.University = UserInfo.university;
            ValidUnfo.Occupation = UserInfo.occupation.type;
            ValidUnfo.Activities = UserInfo.activities;
            ValidUnfo.BirthDate = GetBirthYear();
            ValidUnfo.Personal_political = UserInfo.personal.political;
            ValidUnfo.Personal_religion = UserInfo.personal.religion;
            ValidUnfo.Personal_life_main = UserInfo.personal.life_main;
            ValidUnfo.Personal_people_main = UserInfo.personal.people_main;
            ValidUnfo.Military = UserInfo.military.unit_id;
            ValidUnfo.Home_town = UserInfo.home_town;
            ValidUnfo.Relation = UserInfo.relation;
            ValidUnfo.Faculty = UserInfo.faculty;

            return ValidUnfo;
        }
        public async Task AddFollower(Follower data)
        {            
            Context.Add(data);
            Context.SaveChanges();
        }

        public async Task AddParty()
        {
            idParty = !Context.Party.Any() ? 1 : Context.Party.Max(i => i.Id) + 1;
            Party party = new Party(idParty, nameParty);
            Context.Add(party);
            Context.SaveChanges();
        }

        public async Task AddSubscription(int idFollower, int idParty)
        {
            int idSubscription = !Context.Subscription.Any() ? 0 : Context.Subscription.Max(i => i.Id) + 1;
            Subscription data = new Subscription(idSubscription, idFollower, idParty);
            Context.Add(data);
            Context.SaveChanges();
        }


        public int GetBirthYear()
        {
            int year = 0;
            List<string> birth = new List<string>(UnvalidUserInfo.bdate.Split('.'));
            if (birth.Count() == 3)
                year = int.Parse(birth.Last());
            return year;
        }


        public void DeleteElement(int id1)
        {
            Subscription u = Context.Subscription.Find(id1);
            int id = u.FollowerId;
            Follower fgh = Context.Follower.Find(id);
            Context.Follower.Remove(fgh);
            Context.SaveChanges();
        }
    }
}
