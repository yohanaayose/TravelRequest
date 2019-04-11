using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Core;

namespace TravelRequest.Model
{
    public class TB_M_District : BaseModel
    {
        public string Name { get; set; }
        public TB_M_Province TB_M_Provinces { get; set; }
    }
}
