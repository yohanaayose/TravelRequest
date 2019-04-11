using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
   public interface IAdvancePayment
    {
        List<TB_T_AdvancePayment> get();
        TB_T_AdvancePayment get(int Id);
        bool InsertAdvancePayment(TB_T_AdvancePayment advancePayment);
        bool UpdateAdvancePayment(int Id, TB_T_AdvancePayment advancePayment);
        bool DeleteAdvancePayment(int Id);
    }
}
