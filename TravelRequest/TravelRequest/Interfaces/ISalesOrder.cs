using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface ISalesOrder
    {
        List<TB_M_SalesOrder> get();
        TB_M_SalesOrder get(int Id);
        bool InsertSalesOrder(TB_M_SalesOrder salesOrder);
        bool UpdateSalesOrder(int Id, TB_M_SalesOrder salesOrder);
        bool DeleteSalesOrder(int Id);
    }
}
