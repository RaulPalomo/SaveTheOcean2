using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveTheOcean2;
using SaveTheOcean2.Models;

namespace SaveTheOcean2.Persistence.DAO
{
    public interface IRescueDAO
    {
        void AddRescue(Rescue resc);
        List<Rescue> GetRescues();
        List<Rescue> GetRescueById(string id);
    }
}
