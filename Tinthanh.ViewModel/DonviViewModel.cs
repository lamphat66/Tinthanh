

using DevExpress.Mvvm;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;
using DevExpress.XtraGrid.Views.Base;


namespace Tinthanh.ViewModel
{
    public class DonviViewModel : ViewModelBase
    {
        private readonly TinthanhDBContext _dbContext;
        public virtual BindingList<Donvi> Donvis { get; set; } = new BindingList<Donvi>();
        public virtual Donvi SelectedDonvi { get; set; } = new Donvi();

        public DonviViewModel()
        {
            _dbContext = GetdbContext.dbContext();
            LoadData();
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
                _dbContext.Donvis.Load();
                Donvis = _dbContext.Donvis.Local.ToBindingList();
            }
        }

        public void Save(RowObjectEventArgs e)
        {
            _dbContext.SaveChanges();
        }

        public void Delete()
        {
            if (MessageBoxService.ShowMessage("Xóa 1 đơn vị ?  ", "Xác nhận", MessageButton.OKCancel, MessageIcon.Information) == MessageResult.OK)
            {
                if (SelectedDonvi != null)
                {
                    _dbContext.Donvis.Remove(SelectedDonvi);
                    _dbContext.SaveChanges();
                    
                }
            }
        }
    }
}
