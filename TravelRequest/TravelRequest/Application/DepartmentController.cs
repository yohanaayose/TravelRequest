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
    public class DepartmentController : IDepartment
    {
        static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;
        public bool DeleteDepartment(int Id)
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

        public List<TB_M_Department> get()
        {
            var get = myContext.TB_M_Departments.ToList();
            return get;
        }

        public TB_M_Department get(int Id)
        {
            var get = myContext.TB_M_Departments.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertDepartment(TB_M_Department Department)
        {
            myContext.TB_M_Departments.Add(Department);
            return savedata.Save(myContext);
        }

        public bool UpdateDepartment(int Id, TB_M_Department Department)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = Department.Name;
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
