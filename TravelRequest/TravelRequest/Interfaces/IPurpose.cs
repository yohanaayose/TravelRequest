using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface IPurpose
    {
        List<TB_M_Purpose> get();
        TB_M_Purpose get(int Id);
        bool InsertPurpose(TB_M_Purpose purpose);
        bool UpdatePurpose(int Id, TB_M_Purpose purpose);
        bool DeletePurpose(int Id);
    }
}
