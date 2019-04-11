using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Core;

namespace TravelRequest.Model
{
    public class TB_M_Account : BaseModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual TB_M_Role TB_M_roles { get; set; }
        public virtual TB_M_User TB_M_Users { get; set; }
    }
}
