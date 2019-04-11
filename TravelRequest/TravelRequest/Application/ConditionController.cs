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
    public class ConditionController : ICondition
    {
        static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;
        public bool DeleteCodition(int Id)
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

        public List<TB_M_Condition> get()
        {
            var get = myContext.TB_M_Conditions.ToList();
            return get;
        }

        public TB_M_Condition get(int Id)
        {
            var get = myContext.TB_M_Conditions.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertCondition(TB_M_Condition condition)
        {
            condition.CreateDate = DateTimeOffset.Now.ToLocalTime();
            myContext.TB_M_Conditions.Add(condition);
            return savedata.Save(myContext);
        }

        public bool UpdateCondition(int Id, TB_M_Condition condition)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = condition.Name;
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
