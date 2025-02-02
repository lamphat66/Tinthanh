using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace Tinthanh.Data.Entities
{
    public class Loaidoituong
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public virtual ObservableCollectionListSource<Nhomdoituong>? Nhomdoituongs { get; set; } 
    }
}
