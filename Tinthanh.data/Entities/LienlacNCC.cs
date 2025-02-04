 

namespace Tinthanh.Data.Entities
{
    public class LienlacNCC
    {

        public int Id { get; set; }
        public string? Hoten { get; set; }
        public string? Dienthoai { get; set; }
        public string? Email { get; set; }
        public string? Chucvu { get; set; }
        public string? Bophan { get; set; }
        
        public string? Chinhanh { get; set; }

        public bool? EInvoice { get; set; } = false;
        public bool? Quyetdinh { get; set; } = false;
        public bool? Ngungsd { get; set; } = false;
        public int NhacungcapId { get; set; }
        public virtual Nhacungcap? Nhacungcap { get; set; }
        public string? Didong { get; set; }
        public string? Diachi { get; set; }
        public string? Phanloai { get; set; }
        public int? PhanloaiId { get; set; }



    }
}
