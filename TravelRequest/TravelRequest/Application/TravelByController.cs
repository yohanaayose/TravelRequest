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
    public class TravelByController : ITravelBy
    {
        static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;
        public bool DeleteTravelBy(int Id)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.IsDelete = true;
                myContext.Entry(Get).State = EntityState.Modified;
                return savedata.Save(myContext);
            }
            else
            {
                Console.Write("Data Not Found");
            }
            return status;
        }

        public List<TB_M_TravelBy> get()
        {
            var get = myContext.TB_M_TravelBy.ToList();
            return get;
        }

        public TB_M_TravelBy get(int Id)
        {
            var get = myContext.TB_M_TravelBy.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertTravelBy(TB_M_TravelBy travelBy)
        {
            myContext.TB_M_TravelBy.Add(travelBy);
            return savedata.Save(myContext);
        }

        public bool UpdateTravelBy(int Id, TB_M_TravelBy travelBy)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = travelBy.Name;
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