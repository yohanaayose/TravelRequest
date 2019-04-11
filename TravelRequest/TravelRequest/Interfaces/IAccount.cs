using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface IAccount
    {
        List<TB_M_Account> get();
        TB_M_Account get(int Id);
        bool InsertAccount(TB_M_Account account);

        bool UpdateAccount(int Id, TB_M_Account account);
        bool DeleteAccount(int Id);
    }
}
