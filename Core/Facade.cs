using DatabaseContext;
using DatabaseModels;
using Extractor1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Facade
    {
        private DatabaseContexts _context;
        private Extractor _extractor;
        private Response unvalidUserInfo;
        private Follower _follower;

        private List<string> idUsers;
        private string _idGroupParty;
        private int _idParty;
        private Repository _repository;


        public Facade(DatabaseContexts context, string name, string idGroup)
        {
            _context = context;
            _extractor = new Extractor();
            _follower = new Follower();
            idUsers = new List<string>();
            _idGroupParty = idGroup;
            _idParty = !_context.Party.Any() ? 1 : _context.Party.Max(i => i.Id) /*+ 1*/;
            _repository = new Repository(_context, name, _idParty);

        }
        public async Task GetParty()
        {
            idUsers = await _extractor.FetchInfoGroup(_idGroupParty);
            await _repository.AddParty();
        }

        public async Task GetAllUserInfo()
        {
            foreach (string id in idUsers)
            {
                unvalidUserInfo = await _extractor.FetchInfoUser(int.Parse(id));
                if (IsCorrectData())
                {
                    _follower = ConvertToValidFollowers.Convert(unvalidUserInfo);
                    await _repository.AddFollower(_follower);
                    await _repository.AddSubscription(_follower.Id, _idParty);
                }

            }
        }


        public bool IsCorrectData()
        {
            return unvalidUserInfo.bdate != null && unvalidUserInfo.sex != 0 && !(_context.Follower.Any(s => s.Id == unvalidUserInfo.id)) && ConvertBirth.GetBirthYear(unvalidUserInfo) != 0;
        }
    }
}
