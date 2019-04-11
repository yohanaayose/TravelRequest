using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelRequest.Model
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        { }
        
        public DbSet<TB_M_User> TB_M_Users { get; set; }
        public DbSet<TB_M_Role> TB_M_Roles { get; set; }
        public DbSet<TB_M_Company> TB_M_Companies { get; set; }
        public DbSet<TB_M_Department> TB_M_Departments { get; set; }
        public DbSet<TB_M_Village> TB_M_Villages { get; set; }
        public DbSet<TB_M_SubDistrict> TB_M_SubDistricts { get; set; }
        public DbSet<TB_M_District> TB_M_Districts { get; set; }
        public DbSet<TB_M_Province> TB_M_Provinces { get; set; }
        public DbSet<TB_M_Condition> TB_M_Conditions { get; set; }
        public DbSet<TB_M_Purpose> TB_M_Purposes { get; set; }
        public DbSet<TB_M_SalesOrder> TB_M_SalesOrder { get; set; }
        public DbSet<TB_M_TravelBy> TB_M_TravelBy { get; set; }
        public DbSet<TB_M_TravelRequest> TB_M_TravelRequest { get; set; }
        public DbSet<TB_T_AdvancePayment> TB_T_AdvancePayments { get; set; }
        public DbSet<TB_M_Job> Tb_M_Jobs { get; set; }
        public DbSet<TB_M_Religion> TB_M_Religions { get; set; }
        public DbSet<TB_M_Account> TB_M_Account { get; set; }
    }
}
