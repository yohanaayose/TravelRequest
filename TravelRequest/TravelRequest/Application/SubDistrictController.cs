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
    public class SubDistrictController : ISubDistrict
    {
        static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;

        public SubDistrictController(MyContext _myContext)
        {
            myContext = _myContext;
        }

        public bool DeleteSubDistrict(int Id)
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

        public List<TB_M_SubDistrict> get()
        {
            var get = myContext.TB_M_SubDistricts.ToList();
            return get;
        }

        public TB_M_SubDistrict get(int Id)
        {
            var get = myContext.TB_M_SubDistricts.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertSubDistrict(TB_M_SubDistrict subDistrict)
        {
            subDistrict.CreateDate = DateTimeOffset.Now.ToLocalTime();
            try
            {
                myContext.TB_M_SubDistricts.Add(subDistrict);
                var result = myContext.SaveChanges();
                return result>0;
            }
            catch (Exception y)
            {
                Console.Write(y.StackTrace);
            }
            return savedata.Save(myContext);
        }

        public bool UpdateSubDistrict(int Id, TB_M_SubDistrict subDistrict)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = subDistrict.Name;
                Get.CreateDate= DateTimeOffset.Now.ToLocalTime();
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
