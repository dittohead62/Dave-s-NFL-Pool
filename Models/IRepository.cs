using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAnalysis.Models
{
    public interface IRepository
    {
        IEnumerable<Sport> GetAllSports();
        Sport GetSportById(int Id);
        Sport GetSportByCode(string Code);
    }
}
