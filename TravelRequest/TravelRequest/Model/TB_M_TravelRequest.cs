using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Core;

namespace TravelRequest.Model
{
    public class TB_M_TravelRequest : BaseModel
    {
        public string Notes { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime Derpature { get; set; }
        public DateTime Return { get; set; }
        public string Ticket { get; set; }
        public string CarRental { get; set; }
        public string PaymentMessage { get; set; }
        public string Status { get; set; }
        public int Wages { get; set; }
        public virtual TB_M_SalesOrder TB_M_SalesOrders { get; set; }
        public virtual TB_M_User TB_M_Users { get; set; } 
        public virtual TB_M_District TB_M_Districts { get; set; }
        public virtual TB_T_AdvancePayment TB_T_AdvancePayments { get; set; }
        public virtual TB_M_Condition TB_M_Conditions { get; set; }
        public virtual TB_M_TravelBy TB_M_TravelBy { get; set; }
    }
}
