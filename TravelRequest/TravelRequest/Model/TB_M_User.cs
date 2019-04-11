using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Core;

namespace TravelRequest.Model
{
    public class TB_M_User : BaseModel
    {
        public string Name { get; set; }
        public int Contact { get; set; }
        public DateTime JoinDate { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public int Manager_Id { get; set; }
        public virtual  TB_M_Job TB_M_Jobs{ get; set; }
        public virtual TB_M_Religion Tb_M_Religions { get; set; }
        public virtual TB_M_Department TB_M_Departments { get; set; }
        public virtual TB_M_Village TB_M_Villages { get; set; }
    }
}
