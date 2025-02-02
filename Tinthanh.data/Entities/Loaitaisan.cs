using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class Loaitaisan
    {
        public string Ma { get; set; }
        public string? Ten { get; set; }
        public virtual ObservableCollectionListSource<Nhomtaisan>? Nhomtaisans { get; set; }  
    }
}
