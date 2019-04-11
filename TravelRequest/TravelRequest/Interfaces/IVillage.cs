using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface IVillage
    {
        List<TB_M_Village> get();
        TB_M_Village get(int Id);
        bool InsertVillage(TB_M_Village village);
        bool UpdateVillage(int Id, TB_M_Village village);
        bool DeleteVillage(int Id);
    }
}
