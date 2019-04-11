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
    public class ProvinceController : IProvince
    {
        public static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;

        public bool DeleteProvince(int Id)
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

        public List<TB_M_Province> get()
        {
            var get = myContext.TB_M_Provinces.ToList();
            return get;
        }

        public TB_M_Province get(int Id)
        {
            var get = myContext.TB_M_Provinces.SingleOrDefault(b => b.Id == Id);
            return get;
        }

        public bool InsertProvince(TB_M_Province province)
        {
            province.CreateDate= DateTimeOffset.Now.ToLocalTime();
            myContext.TB_M_Provinces.Add(province);
            return savedata.Save(myContext);
        }

        public bool UpdateProvince(int Id, TB_M_Province province)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = province.Name;
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
