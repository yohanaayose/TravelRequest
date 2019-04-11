using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Core;

namespace TravelRequest.Model
{
    public class TB_M_Village : BaseModel
    {
        public string Name { get; set; }
        public virtual TB_M_SubDistrict TB_M_SubDistricts { get; set; }
    }
}
