
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Tinthanh.Data.Entities
{
    [Table("TieuchiKT")]
    public class TieuchiKT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Ma { get; set; }
        
        public string? Ten { get; set; }
        public virtual ObservableCollectionListSource<TieuchiCT>? TieuchiCTs { get; set; }

    }

}
