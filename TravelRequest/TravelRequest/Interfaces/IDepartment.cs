using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface IDepartment
    {
        List<TB_M_Department> get();
        TB_M_Department get(int Id);
        bool InsertDepartment(TB_M_Department Department);
        bool UpdateDepartment(int Id, TB_M_Department Department);
        bool DeleteDepartment(int Id);
    }
}
