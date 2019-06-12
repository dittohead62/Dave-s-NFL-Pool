using SportsAnalysis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAnalysis.ViewModel
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Sport> Sports { get; set; }
    }
}
