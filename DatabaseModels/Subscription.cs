using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Subscription
    {
        public int Id { get; set; }
        public int FollowerId { get; set; }
        public int PartyId { get; set; }
        public Follower Follower { get; set; }
        public Party Party { get; set; }

        public Subscription(int id, int followerId, int partyId)
        {
            Id = id;
            FollowerId = followerId;
            PartyId = partyId;
        }
    }
}
