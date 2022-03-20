using DatabaseContext;
using DatabaseModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public class Repository
    {
        private DatabaseContexts _context;
        private string _nameParty;
        private int _idParty;

        public Repository(DatabaseContexts context,  string name, int idParty)
        {
            _context = context;
            _nameParty = name;
            _idParty = idParty;
        }



        public async Task AddFollower(Follower data)
        {
            try
            {
                await _context.AddAsync(data);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddParty()
        {
            try
            {
                Party party = new Party(_idParty, _nameParty);
                await _context.AddAsync(party);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddSubscription(int idFollower, int idParty)
        {
            try
            {
                int idSubscription = !_context.Subscription.Any() ? 0 : _context.Subscription.Max(i => i.Id) + 1;
                Subscription data = new Subscription(idSubscription, idFollower, idParty);
                await _context.AddAsync(data);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void DeleteElement(int id1)
        {
            Subscription u = _context.Subscription.Find(id1);
            int id = u.FollowerId;
            Follower fgh = _context.Follower.Find(id);
            _context.Follower.Remove(fgh);
            _context.SaveChanges();
        }


    }
}
