using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface ISubDistrict
    {
        List<TB_M_SubDistrict> get();
        TB_M_SubDistrict get(int Id);
        bool InsertSubDistrict(TB_M_SubDistrict subDistrict);
        bool UpdateSubDistrict(int Id, TB_M_SubDistrict subDistrict);
        bool DeleteSubDistrict(int Id);
    }
}
