using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAnalysis.Models
{
    public class Team
    {
        public int sportId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mascot { get; set; }
        public int OwnerId { get; set; }
        public int ArenaId{ get; set; }

    }
}
