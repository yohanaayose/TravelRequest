using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Interfaces
{
    public interface ICompany
    {
        List<TB_M_Company> get();
        TB_M_Company get(int Id);
        bool InsertCompany(TB_M_Company company);
        bool UpdateCompany(int Id, TB_M_Company company);
        bool DeleteCompany(int Id);
    }
}
