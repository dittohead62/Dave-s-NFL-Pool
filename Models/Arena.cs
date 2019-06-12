using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAnalysis.Models
{
    public class Arena
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
