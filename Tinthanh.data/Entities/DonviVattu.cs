

namespace Tinthanh.Data.Entities
{
    public class DonviVattu
    {
        public int Id { get; set; }
        public string? Donvi { get; set; }
        public double? Heso { get; set; }
        public double? Trongluong { get; set; }

        public bool? Ngungsd { get; set; } = false;
        public int? VattuId { get; set; }
        public virtual Vattu? Vattu { get; set; }
        public double? Dongia { get; set; } = 0;
          
    }

}
