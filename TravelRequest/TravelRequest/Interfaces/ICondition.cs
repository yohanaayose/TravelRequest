using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface ICondition
    {
        List<TB_M_Condition> get();
        TB_M_Condition get(int Id);
        bool InsertCondition(TB_M_Condition condition);
        bool UpdateCondition(int Id, TB_M_Condition condition);
        bool DeleteCodition(int Id);
    }
}
