using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface ITravelRequest
    {
        List<TB_M_TravelRequest> get();
        TB_M_TravelRequest get(int Id);
        bool InsertTravelRequest(TB_M_TravelRequest travelRequest);
        bool UpdateTravelRequest(int Id, TB_M_TravelRequest travelRequest);
        bool DeleteTravelRequest(int Id);
    }
}
