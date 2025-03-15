

using DevExpress.Mvvm;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;
using System.Data;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;

namespace Tinthanh.ViewModel
{
    public class KhoViewModel
    {

        private readonly TinthanhDBContext _dbContext;
        public virtual List<LookupItems> lstKho { get; set; }
        public virtual Kho SelectedItem { get; set; }
        public virtual bool IsModified { get; protected set; }

        private int OldId;
        public KhoViewModel()
        {
            _dbContext = GetdbContext.dbContext();
            LoadDanhsach();
           
            SelectedItem = _dbContext.Khos.FirstOrDefault();

        }
        public bool CanCloseForm()
        {
            return !IsModified;

        }
        public void CloseForm()
        {

            Messenger.Default.Send("string","Close"); // Gửi tin nhắn đóng form
        }
        public void LoadDanhsach()
        {
            lstKho = SQLHelper.ExecQueryData<LookupItems>($"Select Id ,Ma,Ten from Kho").ToList();

        }

        public DataTable Nhomkho()
        {
            return SQLHelper.ExecQueryDataAsDataTable($"select Ma,Ten from Nhomdoituong where Madt='KB'");
        }
        protected IMessageBoxService MessageBoxService
        {
            // using the GetService<> extension method for obtaining service instance
            get { return this.GetService<IMessageBoxService>(); }
        }


        public void Loaddata(FocusedRowObjectChangedEventArgs e)
        {
            var row = e.Row as LookupItems;

            var item = _dbContext.Khos.Find(row.Id);
            if (item != null)
            {
                SelectedItem = item;
                OldId = item.Id;
            }

        }
        public bool CanCancel()
        {
            return IsModified;

        }
        public void Cancel()
        {


            var item = _dbContext.Khos.Find(OldId);
            if (item != null)
            {
                _dbContext.Entry(item).Reload();
                SelectedItem = null;
                SelectedItem = item;
                IsModified = false;
            }

        }


        public void TestChanged(ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                IsModified = true;
            }
        }
        public void Delete()
        {
            if (MessageBoxService.ShowMessage("Xóa 1 kho  ?  ", "Xác nhận", MessageButton.OKCancel, MessageIcon.Information) == MessageResult.OK)
            {
                if (SelectedItem != null)
                {
                    _dbContext.Khos.Remove(SelectedItem);
                    _dbContext.SaveChanges();
                    lstKho.RemoveAll(x => x.Id == SelectedItem.Id);

                }
            }
        }


        public bool CanSave()
        {
            return IsModified;

        }

        public void Save()
        {
            if (SelectedItem == null) return;
            if (SelectedItem.Id == 0)
            {
                _dbContext.Khos.Add(SelectedItem);

            }
            else _dbContext.Khos.Update(SelectedItem);

            _dbContext.SaveChanges();
            IsModified = false;

        }
        public void OnIsModifiedChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Save());
            this.RaiseCanExecuteChanged(x => x.Add());
            this.RaiseCanExecuteChanged(x => x.CloseForm());
            this.RaiseCanExecuteChanged(x => x.Cancel());
        }

        public bool CanAdd()
        {
            return !IsModified;

        }

        public void Add()
        {

            SelectedItem = new Kho
            {
                Ma = Dungchung.Sinhmadoituong("KB", 4),
                //Ten = "",
                //Tentat = "",
                //Diachi = "",
                //Manhom = null,
                Users = Dungchung.un,

            };
            IsModified = true;
            Messenger.Default.Send("string", "Focus"); 

        }

    }
}
