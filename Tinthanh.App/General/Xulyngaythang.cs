using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Tinthanh.App.General
{
    public class Xulyngaythang  
    {

        public virtual DateTime Tungay { get; set; }

        public virtual DateTime Denngay { get; set; }
        public virtual int Thang { get; set; }
        public virtual int Quy { get; set; }
        public virtual int Nam { get; set; }
        public virtual int Tuychon { get; set; }

        public Xulyngaythang()
        {


            Tuychon = -1;
            Thang = DateTime.Now.Month;
            Quy = Dungchung.GetQuater(DateTime.Now.Date);
            Nam = DateTime.Now.Year;
            Tungay = Dungchung.Ngaydauthang(Thang, Nam);
            Denngay = DateTime.Now.Date;

        }

        protected void OnThangChanged()
        {
            Capnhat();
        }

        protected void OnQuyChanged()
        {
            Capnhat();
        }


        protected void OnNamChanged()
        {
            Capnhat();
        }

        protected void OnTuychonChanged()
        {
            Capnhat();
        }

        public void Capnhat()
        {
            switch (Tuychon)
            {
                case 0:
                    Tungay = Dungchung.Ngaydauthang(Thang, Nam);
                    Denngay = Dungchung.Ngaycuoithang(Thang, Nam);
                    break;
                case 1:
                    Tungay = Dungchung.Ngaydauquy(Quy, Nam);
                    Denngay = Dungchung.Ngaycuoiquy(Quy, Nam);
                    break;
                case 2:
                    Tungay = Dungchung.Ngaydaunam(Nam);
                    Denngay = Dungchung.Ngaycuoinam(Nam);
                    break;

            }

        }

      


    }
}
