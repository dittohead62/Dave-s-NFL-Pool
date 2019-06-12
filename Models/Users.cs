using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAnalysis.Models
{
    public class Users
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public string userFirstName { get; set; }
        public string userLastName { get; set; }
        public string userAffiliation { get; set; }
        public bool userIsActive { get; set; }
    }
}
