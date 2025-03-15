using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinthanh.Data.Entities
{
    public class PhieudinhgiaCT
    {
        
        public int Id { get; set; }
        public int PhieudinhgiaId { get; set; }
        
        public string? Masp { get; set; }
        
        public string? Tensp { get; set; }
        public float TT { get; set; }
        public float V { get; set; }
        public float TL { get; set; }
        public float Gia1 { get; set; }
        public float Gia2 { get; set; }
        public float Gia3 { get; set; }
        public float Gia4 { get; set; }
        public float Gia5 { get; set; }
        public float D { get; set; }
        public float R { get; set; }
        public float C { get; set; }
        public int SoCAV { get; set; }
        public float Giathanh { get; set; }
        public float Baogia { get; set; }
        public float Moq { get; set; }
        public bool Chon { get; set; }
        public virtual Phieudinhgia Phieudinhgia { get; set; }
    }
}
