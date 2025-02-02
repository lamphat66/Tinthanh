using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class User_CT
    {
        public int Id { get; set; }
        public string? UsersMa { get; set; }
        public int MenuId { get; set; }
        public string? TenMenu { get; set; }
        public int? Quyen { get; set; }
        public User? User { get; set; }
    }

}
