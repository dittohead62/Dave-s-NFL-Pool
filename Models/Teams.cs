using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAnalysis.Models
{
    public class Teams
    {
        public int sportId { get; set; }
        public int teamId { get; set; }
        public string teamName { get; set; }
        public string teamMascot { get; set; }
        public int teamOwnerId { get; set; }
        public int teamArenaId{ get; set; }

    }
}
