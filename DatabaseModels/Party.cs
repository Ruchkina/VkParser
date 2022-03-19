using System;
using System.Collections.Generic;

namespace DatabaseModels
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Subscription> Subscription { get; set; }

        public Party(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
