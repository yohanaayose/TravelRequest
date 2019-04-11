using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Core;
using TravelRequest.Interfaces;
using TravelRequest.Model;

namespace TravelRequest.Application
{
    public class AdvancePaymentController : IAdvancePayment
    {
        static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;
        public bool DeleteAdvancePayment(int Id)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.IsDelete = true;
                Get.DeleteDate = DateTimeOffset.Now.ToLocalTime();
                myContext.Entry(Get).State = EntityState.Modified;
                return savedata.Save(myContext);
            }
            else
            {
                Console.Write("Data Not Found");
            }
            return status;
        }

        public List<TB_T_AdvancePayment> get()
        {
            var get = myContext.TB_T_AdvancePayments.ToList();
            return get;
        }

        public TB_T_AdvancePayment get(int Id)
        {
            var get = myContext.TB_T_AdvancePayments.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertAdvancePayment(TB_T_AdvancePayment advancePayment)
        {
            advancePayment.CreateDate = DateTimeOffset.Now.ToLocalTime();
            myContext.TB_T_AdvancePayments.Add(advancePayment);
            return savedata.Save(myContext);
        }

        public bool UpdateAdvancePayment(int Id, TB_T_AdvancePayment advancePayment)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = advancePayment.Name;
                Get.EditDate = DateTimeOffset.Now.ToLocalTime();
                myContext.Entry(Get).State = EntityState.Modified;
                return savedata.Save(myContext);
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
}
