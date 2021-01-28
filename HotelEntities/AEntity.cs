using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelEntities
{
    public abstract class AEntity
    {
        
        public int Id { get; set; }
       
        public string FirsName { get; set; }
        
        public string LastName { get; set; }



        //public int Id { get; set; }
        //[Required]
        //[MinLength(5)]
        //public string FirsName { get; set; }

        //public string LastName { get; set; }
    }
}
