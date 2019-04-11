using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface ITravelBy
    {
        List<TB_M_TravelBy> get();
        TB_M_TravelBy get(int Id);
        bool InsertTravelBy(TB_M_TravelBy travelBy);
        bool UpdateTravelBy(int Id, TB_M_TravelBy travelBy);
        bool DeleteTravelBy(int Id);
    }
}
