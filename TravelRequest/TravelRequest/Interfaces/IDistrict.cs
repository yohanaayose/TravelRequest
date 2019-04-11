using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface IDistrict
    {
        List<TB_M_District> get();
        TB_M_District get(int Id);
        bool InsertDistrict(TB_M_District district);
        bool UpdateDistrict(int Id, TB_M_District district);
        bool DeleteDistrict(int Id);
    }
}
