using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAnalysis.Models
{
    public class Arenas
    {
        public int arenaId { get; set; }
        public string arenaName { get; set; }
        public int arenaCapacity { get; set; }
        public string arenaCity { get; set; }
        public string arenaState { get; set; }
    }
}
