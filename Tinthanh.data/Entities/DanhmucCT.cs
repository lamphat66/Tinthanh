using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class DanhmucCT
    {
        public int Id { get; set; }
        public int DanhmucId { get; set; }
        public int STT { get; set; }
        public string Ten { get; set; }
        public bool Ngungsd { get; set; } = false;
        public virtual Danhmuc? Danhmuc { get; set; }   

    }

}
