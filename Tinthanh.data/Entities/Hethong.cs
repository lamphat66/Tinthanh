using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    [Table("Hethong")]
    public class Hethong
    {
        [Key]
        [MaxLength(20)]
        public string Macty { get; set; }
        public string? Tencty { get; set; }
        public string? Diachi { get; set; }
        public string? Dienthoai { get; set; }
        public string? Masothue { get; set; }
        public DateTime? KSDenngay { get; set; }
        public int? SongayKS { get; set; }
        public string? Version { get; set; }
    }

}
