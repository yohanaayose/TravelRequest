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
    public class AccountController : IAccount

    {
        MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;
        public bool DeleteAccount(int Id)
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

        public List<TB_M_Account> get()
        {
            var get = myContext.TB_M_Account.ToList();
            return get;
        }

        public TB_M_Account get(int Id)
        {
            var get = myContext.TB_M_Account.SingleOrDefault(b => b.Id == Id);
            return get;
        }

        public bool InsertAccount(TB_M_Account account)
        {
            myContext.TB_M_Account.Add(account);
            return savedata.Save(myContext);
        }

        public bool UpdateAccount(int Id, TB_M_Account account)
        {
            var Get = get(Id);
            if (Get != null)
            {
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
