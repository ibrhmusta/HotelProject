namespace HotelEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Customer : AEntity
    {

        public string TcNo { get; set; }

        public string E_mail { get; set; }
    }
}