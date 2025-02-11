using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class YeucauGCK_CT
    {
        public int Id { get; set; }
        public int? YeucauGCKId { get; set; }
        [MaxLength(100)]
        public string? Tenvt { get; set; }
        public float? Soluong { get; set; }
        [MaxLength(20)]
        public string? Donvi { get; set; }
        public virtual YeucauGCK YeucauGCK { get; set; }
    }

}
