using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class Nhomdanhdiem
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public virtual Loaidanhdiem? Loaidanhdiem { get; set; }
        public string Madd { get; set; }
        public bool ? Ngungsd { get; set; }= false;
    }
}
