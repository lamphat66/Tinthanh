

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Tinthanh.Data.Entities
{
    public class Danhmuc
    {
     
        public int Ma { get; set; }
        public string? Ten { get; set; }
        public virtual ObservableCollectionListSource<DanhmucCT>? DanhmucCTs { get; set; } 
    }
}

