

using DevExpress.Mvvm;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;
using System.Data;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using Dapper;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraGrid.Views.Grid;
using static System.Net.WebRequestMethods;
using System.Diagnostics;
using DevExpress.XtraEditors.Controls;

namespace Tinthanh.ViewModel
{
    public class KhachhangViewModel
    {
        private readonly TinthanhDBContext _dbContext;
        public virtual  List<LookupItems> lstKhachhang { get; set; }
        public virtual Khachhang SelectedItem { get; set; }
        public virtual BindingList<LienlacKH> lstLienlac { get; set; }
        public virtual LienlacKH SelectedLienlac { get; set; } = new LienlacKH();

        public virtual BindingList<Khachhang_Tailieu> lstTailieu { get; set; }
        public virtual Khachhang_Tailieu SelectedTailieu { get; set; } = new Khachhang_Tailieu();


        private int OldId;
        public KhachhangViewModel()
        {
            _dbContext = GetdbContext.dbContext();
            LoadDanhsach1();
           
            SelectedItem = _dbContext.Khachhangs.FirstOrDefault();

        }

      
        public void CloseForm()
        {
           if( _dbContext!.ChangeTracker.HasChanges())
            {
              if (MessageBoxService.ShowMessage("Dữ liệu đã thay đổi, bạn có muốn lưu không ?", "Xác nhận", MessageButton.YesNo, MessageIcon.Information) == MessageResult.Yes)
                {
                    Save();
                   
                }
            }
            Messenger.Default.Send("string", "Close"); // Gửi tin nhắn đóng form
        }
        
        public void LoadDanhsach1(string filter = "")
        {
            lstKhachhang = GetDataDanhsach(1, filter) as  List<LookupItems>;

        }
        public void LoadDanhsachByFilter(string filter )
        {
            lstKhachhang = GetDataDanhsach(2, filter) as List<LookupItems>;

        }
        public  object GetDataDanhsach(int Loai, string filter)
        {
            string Ten = "pr_Timdanhsach";

            DynamicParameters para = new DynamicParameters();
            para.Add("@Tenbang", "Khachhang", DbType.String, ParameterDirection.Input);
            para.Add("@Somautin", Loai, DbType.Int32, ParameterDirection.Input);
            para.Add("@Ten", filter, DbType.String, ParameterDirection.Input);
            return SQLHelper.ExecProcedureData<LookupItems>(Ten, para);

        }

        public DataTable Nhomkhachhang()
        {
            return SQLHelper.ExecQueryDataAsDataTable($"select Ma,Ten from Nhomdoituong where Madt='KH'");
        }

        public List<DanhmucCT> Phanloai()
        {
            return SQLHelper.ExecQueryData<DanhmucCT>("select Ma,Ten from Danhmuc_CT where DanhmucId=200").ToList();
        }

        public DataTable Khuvuc()
        {
            return SQLHelper.ExecQueryDataAsDataTable($"select Ma,Ten from Khuvuc");
        }
        protected IMessageBoxService MessageBoxService
        {
            // using the GetService<> extension method for obtaining service instance
            get { return this.GetService<IMessageBoxService>(); }
        }

      
        public void Loaddata(FocusedRowObjectChangedEventArgs e)
        {
            if (Changed()) Save();


            var row = e.Row as LookupItems;

            var item = _dbContext.Khachhangs.Find(row.Id);
            if (item != null)
            {
                SelectedItem = item;
                OldId = item.Id;
                              
               Loadlienlac();
               LoadTailieu();

            }

        }
        private void Loadlienlac()
        {
           

            if (SelectedItem != null)
            {
                _dbContext.Entry(SelectedItem).Collection(e => e.LienlacKHs).Load();
                lstLienlac = SelectedItem.LienlacKHs.ToBindingList();

            }


        }

        private void LoadTailieu()
        {


            if (SelectedItem != null)
            {
                _dbContext.Entry(SelectedItem).Collection(e => e.Khachhang_Tailieus).Load();
                lstTailieu = SelectedItem.Khachhang_Tailieus.ToBindingList();

            }


        }


        public void Cancel( )
        {
            var item = _dbContext.Khachhangs.Find(OldId);
            if (item != null)
            {
                _dbContext.Entry(item).Reload();
                SelectedItem =null;
                SelectedItem  = item ;
                Loadlienlac();
                LoadTailieu();

            }
        }

        private bool Changed()
        {
            return _dbContext.ChangeTracker.HasChanges();
        }

       
        public void Delete()
        {
            if (MessageBoxService.ShowMessage("Xóa 1 khách hàng ?  ", "Xác nhận", MessageButton.OKCancel, MessageIcon.Information) == MessageResult.OK)
            {
                if (SelectedItem != null)
                {
                    _dbContext.Khachhangs.Remove(SelectedItem);
                    _dbContext.SaveChanges();
                    lstKhachhang.RemoveAll(x => x.Id == SelectedItem.Id);
                    
                }
            }
        }

       
       
        public void Save()
        {
            if (SelectedItem == null) return;
            if (SelectedItem.Id == 0)
            {
                _dbContext.Khachhangs.Add(SelectedItem);
                
            }
            else _dbContext.Khachhangs.Update(SelectedItem);

            _dbContext.SaveChanges();
           

        }
        

        public void Add()
        {
            if (Changed()) Save();
            
                
            SelectedItem = new Khachhang
            {
                Ma = Dungchung.Sinhmadoituong("KH", 4),
                
                Users = Dungchung.un,
                
            };
            Loadlienlac();
            //SelectedLienlac = new LienlacKH();
            
            Messenger.Default.Send("string","Focus");

        }

    

    }
}
