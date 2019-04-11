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
    public class TravelRequestController : ITravelRequest
    {
        static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;

        public bool DeleteTravelRequest(int Id)
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

        public List<TB_M_TravelRequest> get()
        {
            var get = myContext.TB_M_TravelRequest.ToList();
            return get;
        }

        public TB_M_TravelRequest get(int Id)
        {
            var get = myContext.TB_M_TravelRequest.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertTravelRequest(TB_M_TravelRequest travelRequest)
        {
            myContext.TB_M_TravelRequest.Add(travelRequest);
            return savedata.Save(myContext);
        }

        public bool UpdateTravelRequest(int Id, TB_M_TravelRequest travelRequest)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Notes = travelRequest.Notes;
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
