namespace HotelEntities
{
    using HotelEntities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public class Personel : AEntity
    {
    
       
        public decimal? Salary { get; set; }

 
        public string Adress { get; set; }
    }
}
