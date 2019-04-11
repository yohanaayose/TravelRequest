using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface IUser
    {
        List<TB_M_User> get();
        TB_M_User get(int id);
        bool InsertUser(TB_M_User user);
        bool UpdateUser(int Id, TB_M_User user);
        bool DeleteUser(int Id);
    }
}
