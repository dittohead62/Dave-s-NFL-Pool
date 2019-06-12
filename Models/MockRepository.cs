using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAnalysis.Models
{
    public class MockRepository : IRepository
    {
        private List<Sports> _sports;
        private List<Teams> _teams;

        public MockRepository()
        {
            if (_sports == null)
            {
                InitializeRepository();
            }

        }
        private void InitializeRepository()
        {

        }
    }
}
