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
    public class DistrictController : IDistrict
    {
        /*static */MyContext myContext = new MyContext();
        //SaveData savedata = new SaveData();
        bool status = false;
        public bool DeleteDistrict(int Id)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.IsDelete = true;
                Get.DeleteDate = DateTimeOffset.Now.ToLocalTime();
                myContext.Entry(Get).State = EntityState.Modified;
                return /*savedata.Save(myContext)*/true;
            }
            else
            {
                Console.Write("Data Not Found");
            }
            return status;
        }

        public List<TB_M_District> get()
        {
            var get = myContext.TB_M_Districts.ToList();
            return get;
        }

        public TB_M_District get(int Id)
        {
            var get = myContext.TB_M_Districts.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertDistrict(TB_M_District district)
        {
            district.CreateDate = DateTimeOffset.Now.ToLocalTime();
            myContext.TB_M_Districts.Add(district);
            var result = myContext.SaveChanges();
            return result>0;
        }

        public bool UpdateDistrict(int Id, TB_M_District district)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = district.Name;
                Get.EditDate = DateTimeOffset.Now.ToLocalTime();
                myContext.Entry(Get).State = EntityState.Modified;
                return /*savedata.Save(myContext)*/true;
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
}
