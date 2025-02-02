using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class User
    {
        public string Ma { get; set; }
        public string? Ten { get; set; }
        public string Password { get; set; }
        public string? Bophan { get; set; }
        public DateTime? Ngaytao { get; set; }
        public bool? Locked { get; set; }
        public bool? IsSuperUser { get; set; }
        public List<User_CT>? UserCTs { get; set; }
    }

}
