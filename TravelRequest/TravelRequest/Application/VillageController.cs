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
    public class VillageController : IVillage
    {
        static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;
        public bool DeleteVillage(int Id)
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

        public List<TB_M_Village> get()
        {
            var get = myContext.TB_M_Villages.ToList();
            return get;
        }

        public TB_M_Village get(int Id)
        {
            var get = myContext.TB_M_Villages.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertVillage(TB_M_Village village)
        {
            village.CreateDate = DateTimeOffset.Now.ToLocalTime();
            myContext.TB_M_Villages.Add(village);
            return savedata.Save(myContext);
        }

        public bool UpdateVillage(int Id, TB_M_Village village)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = village.Name;
                Get.CreateDate = DateTimeOffset.Now.ToLocalTime();
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
