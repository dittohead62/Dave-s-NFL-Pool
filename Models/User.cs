using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAnalysis.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Affiliation { get; set; }
        public bool IsActive { get; set; }
    }
}
