using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class Bophan
    {
        public int Id { get; set; }
        public string? Ma { get; set; }
        public string? Ten { get; set; }
        public int? Thuoc { get; set; }
        public string? Truongbophan { get; set; }

        public bool? Sanxuat { get; set; }


    }
}
