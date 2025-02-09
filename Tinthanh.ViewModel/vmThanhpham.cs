

using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel;
using System.Data;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;
 

namespace Tinthanh.ViewModel
{
    public class vmThanhpham
    {
        private TinthanhDBContext? dbContext;
        public BindingList<Thanhpham>? bdSource { get; set; }
        public BindingList<Donvisanpham>? bdDonvi { get; set; }
         
        public vmThanhpham()
        {
            

        }

        

        public void Save()
        {
            try
            {
                
                this.dbContext!.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
        public bool Changed ()
        {
            return dbContext.ChangeTracker.HasChanges();
        }
         
        public void Load()
        {
            dbContext = GetdbContext.dbContext();
            dbContext?.Thanhphams.Load();

            bdSource = dbContext?.Thanhphams.Local.ToBindingList();
        }

        public ObservableCollectionListSource<Donvisanpham> dsDonviSanpham(Thanhpham data)
        {
            if (data != null)
            {
                this.dbContext.Entry(data).Collection(e => e.Donvisanphams).Load();
                return data.Donvisanphams;
            }
            return new ObservableCollectionListSource<Donvisanpham>();
        }
        public DataTable GetDataDanhsach(int Loai, string filter)
        {
            string Ten = "pr_Timdanhsach";

            DynamicParameters para = new DynamicParameters();
            para.Add("@Tenbang", "Thanhpham", DbType.String, ParameterDirection.Input);
            para.Add("@Somautin", Loai, DbType.Int32, ParameterDirection.Input);
            para.Add("@Ten", filter, DbType.String, ParameterDirection.Input);
            return SQLHelper.ExecProcedureDataAsDataTable(Ten, para);

        }
    }
}
