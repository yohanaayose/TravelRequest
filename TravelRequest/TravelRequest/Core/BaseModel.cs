using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelRequest.Core
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset EditDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
    }
}
