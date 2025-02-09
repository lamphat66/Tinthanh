

using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;


namespace Tinthanh.ViewModel
{
    public class vmDonvi
    {
        private TinthanhDBContext? dbContext;
        public BindingList<Donvi>? bd { get; set; }

        public vmDonvi()
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
            dbContext?.Donvis.Load();

            bd = dbContext?.Donvis.Local.ToBindingList();
        }
        
    }
}
