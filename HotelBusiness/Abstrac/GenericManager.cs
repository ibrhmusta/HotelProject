using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace HotelBusiness
{
    public class GenericManager<T>
    {

        HotelDal.DataBaseManager<T> _db;
        
        public GenericManager()
        {
            _db = new HotelDal.DataBaseManager<T>();
        }
        public bool Insert(T entity)
        {

            Type type = typeof(T);
            var results = new List<ValidationResult>();
            var context = new ValidationContext(entity, serviceProvider: null, items: null);
            var isValid = Validator.TryValidateObject(entity, context, results,true);
            if (!isValid)
            {
                foreach (var validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }

                return false;
            }

            return _db.Insert(entity);
        }

        public bool Update(T entity)
        {

            return _db.Update(entity);

        }

        public bool Delete(T entity)
        {

            return _db.Delete(entity);


        }
    }
}
