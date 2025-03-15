

using DevExpress.Mvvm;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;
 


namespace Tinthanh.ViewModel
{
    public class DanhmucViewModel : ViewModelBase
    {
        private readonly TinthanhDBContext _dbContext;
        public virtual BindingList<Danhmuc> Danhmucs { get; set; } = new BindingList<Danhmuc>();
        public virtual Danhmuc SelectedDanhmuc { get; set; } = new Danhmuc();
        public virtual BindingList<DanhmucCT> lstDanhmucCT { get; set; }
        public virtual DanhmucCT SelectedDanhmucCT  { get; set; } = new DanhmucCT();

        public DanhmucViewModel()
        {
            _dbContext = GetdbContext.dbContext();
            LoadData();
            
            SelectedDanhmuc = _dbContext.Danhmucs.FirstOrDefault();
            LoadCT(null);
        }

        public void LoadCT(FocusedRowObjectChangedEventArgs e)
        {


            if (SelectedDanhmuc != null)
            {
                _dbContext.Entry(SelectedDanhmuc).Collection(e => e.DanhmucCTs).Load();
                lstDanhmucCT = SelectedDanhmuc.DanhmucCTs.ToBindingList();

            }

        }
        public void Save(RowObjectEventArgs e)
        {
            _dbContext.SaveChanges();
        }

        protected IMessageBoxService MessageBoxService
        {
            // using the GetService<> extension method for obtaining service instance
            get { return this.GetService<IMessageBoxService>(); }
        }

        public void CloseForm()
        {

            Messenger.Default.Send("string", "Close");  
        }

        public void Addnew()
        {

            Messenger.Default.Send("string", "New");  
        }
        public void LoadData()
        {
            if (_dbContext?.Donvis != null)
            {
                _dbContext.Danhmucs.Load();
                Danhmucs = _dbContext.Danhmucs.Local.ToBindingList();
            }
        }
        
        public void Delete()
        {
            if (MessageBoxService.ShowMessage("Xóa 1 danh mục ?  ", "Xác nhận", MessageButton.OKCancel, MessageIcon.Information) == MessageResult.OK)
            {
                if (SelectedDanhmuc != null)
                {
                    _dbContext.Danhmucs.Remove(SelectedDanhmuc);
                    _dbContext.SaveChanges();
                     
                }
            }
        }

        public void DeleteCT()
        {
            if (MessageBoxService.ShowMessage("Xóa 1 danh mục chi tiết ?  ", "Xác nhận", MessageButton.OKCancel, MessageIcon.Information) == MessageResult.OK)
            {
                if (SelectedDanhmuc != null)
                {

                    _dbContext.DanhmucCTs.Remove(SelectedDanhmucCT);
                    _dbContext.SaveChanges();


                }

            }
        }
    }
}
