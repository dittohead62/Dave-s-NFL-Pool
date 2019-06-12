using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAnalysis.Models
{
    public class MockRepository : IRepository
    {
        private List<Sport> _sports;
        //private List<Teams> _teams;

        public MockRepository()
        {
            if (_sports == null)
            {
                InitializeRepository();
            }
        }
        private void InitializeRepository()
        {
            _sports = new List<Sport>
            { new Sport { Id=1, Code="NFL", Name="National Football League" },
              new Sport { Id=2, Code="MLB", Name="Major League Baseball" },
              new Sport { Id=3, Code="NBA", Name="National Basketball Association" },
              new Sport { Id=4, Code="NHL", Name="National Hockey League" }
            };
        }

        public IEnumerable<Sport> GetAllSports()
        {
            return _sports;
        }

        public Sport GetSportById(int id)
        {
            return _sports.FirstOrDefault(i => i.Id == id);
        }

        public Sport GetSportByCode(string code)
        {
            return _sports.FirstOrDefault(i => i.Code == code);
        }
    }
}
