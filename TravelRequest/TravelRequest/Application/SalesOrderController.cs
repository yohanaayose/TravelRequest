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
    public class SalesOrderController : ISalesOrder
    {
        static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;
        public bool DeleteSalesOrder(int Id)
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

        public List<TB_M_SalesOrder> get()
        {
            var get = myContext.TB_M_SalesOrder.ToList();
            return get;
        }

        public TB_M_SalesOrder get(int Id)
        {
            var get = myContext.TB_M_SalesOrder.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertSalesOrder(TB_M_SalesOrder salesOrder)
        {
            salesOrder.CreateDate = DateTimeOffset.Now.ToLocalTime();
            myContext.TB_M_SalesOrder.Add(salesOrder);
            return savedata.Save(myContext);
        }

        public bool UpdateSalesOrder(int Id, TB_M_SalesOrder salesOrder)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = salesOrder.Name;
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
