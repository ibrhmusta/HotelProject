using System;
using HotelEntities;
using System.Data.Entity;
namespace HotelDal
{
    public class DataBaseManager<T>
    {
        Model1 _Db = new Model1();
        public DataBaseManager()
        {

        }
        public bool Insert(T entity)
        {          
            if (entity != null)
            {
                _Db.Entry(entity).State = EntityState.Added;
                _Db.SaveChanges();
                return true;
            } 
            return false;
        }

        public bool Update(T entity)
        {
            if (entity != null) return true;
            return false;
        }
        public bool Delete(T entity)
        {
            if (entity != null) return true;
            return false;
        }
    }
}
