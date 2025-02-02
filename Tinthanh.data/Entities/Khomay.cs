

namespace Tinthanh.Data.Entities
{
    public class Khomay
    {
        public int Ma { get; set; }
        public string? Ten { get; set; }
        public double? Loinhuan { get; set; } = 0;
        public double? Giakhuon { get; set; } = 0;
        public double? GiakhuonUSD { get; set; } = 0;
        public double? LoinhuanM { get; set; } = 0;
        public bool? Ngungsd { get; set; } = false;
    }

}
