using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class CongviecBT
    {
        
        public int Ma { get; set; }
        public required  string Ten { get; set; }
        public bool? Ngungsd { get; set; }
        public bool? IsValue { get; set; }
        public string? Dungcu { get; set; }
        public bool? Baotrixe { get; set; }
    }

}
