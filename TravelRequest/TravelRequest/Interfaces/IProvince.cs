using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
   public interface IProvince
    {
        List<TB_M_Province> get();
        TB_M_Province get(int Id);
        bool InsertProvince(TB_M_Province province);
        bool UpdateProvince(int Id, TB_M_Province province);
        bool DeleteProvince(int Id);
    }
}
