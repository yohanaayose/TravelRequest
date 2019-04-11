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
    public class CompanyController : ICompany
    {
        static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;
        public bool DeleteCompany(int Id)
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

        public List<TB_M_Company> get()
        {
            var get = myContext.TB_M_Companies.ToList();
            return get;
        }

        public TB_M_Company get(int Id)
        {
            var get = myContext.TB_M_Companies.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertCompany(TB_M_Company company)
        {
            myContext.TB_M_Companies.Add(company);
            return savedata.Save(myContext);
        }

        public bool UpdateCompany(int Id, TB_M_Company company)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = company.Name;
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
