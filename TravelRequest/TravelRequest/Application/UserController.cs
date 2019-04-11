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
    public class UserController :IUser
    {
        public static MyContext myContext = new MyContext();
        SaveData savedata = new SaveData();
        bool status = false;

        public bool DeleteUser(int Id)
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

        public List<TB_M_User> get()
        {
            var get = myContext.TB_M_Users.ToList();
            return get;
        }

        public TB_M_User get(int Id)
        {
            var get = myContext.TB_M_Users.SingleOrDefault(a => a.Id == Id);
            return get;
        }

        public bool InsertUser(TB_M_User user)
        {
            user.CreateDate = DateTimeOffset.Now.ToLocalTime();
            myContext.TB_M_Users.Add(user);
            return savedata.Save(myContext);
        }

        public bool UpdateUser(int Id, TB_M_User user)
        {
            var Get = get(Id);
            if (Get != null)
            {
                Get.Name = user.Name;
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
