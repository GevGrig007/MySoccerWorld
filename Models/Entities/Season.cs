using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Models.Entities
{
    public class Season
    {
        public int Id { get; set; }
        public double Data { get; set; }
        public virtual ICollection<Tournament> Tournaments { get; set; }
    }
}
