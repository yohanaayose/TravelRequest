using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Core;

namespace TravelRequest.Model
{
   public class TB_M_Department : BaseModel
    {
        public string Name { get; set; }
        public virtual TB_M_Company TB_M_Companies { get; set; }
    }
}
