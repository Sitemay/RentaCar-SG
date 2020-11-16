using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentAcar_SG.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }


        public List<Vehicle> Vehicles { get; set; }

    }
}