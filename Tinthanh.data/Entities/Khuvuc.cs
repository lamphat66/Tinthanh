using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class Khuvuc
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string? Ten { get; set; }
        public bool? Ngoainuoc { get; set; }
        public string? Macu { get; set; }
    }

}
