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
    public class PurposeController : IPurpose
    {
        static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;
        public bool DeletePurpose(int Id)
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

        public List<TB_M_Purpose> get()
        {
            var get = myContext.TB_M_Purposes.ToList();
            return get;
        }

        public TB_M_Purpose get(int Id)
        {
            var get = myContext.TB_M_Purposes.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertPurpose(TB_M_Purpose purpose)
        {
            purpose.CreateDate = DateTimeOffset.Now.ToLocalTime();
            myContext.TB_M_Purposes.Add(purpose);
            return savedata.Save(myContext);
        }

        public bool UpdatePurpose(int Id, TB_M_Purpose purpose)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = purpose.Name;
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
