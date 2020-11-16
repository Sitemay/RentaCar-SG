using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;


namespace RentAcar_SG.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string AracAdi { get; set; }
        public string ModelAdi { get; set; }
        public string ModelYili { get; set; }
        public string Resim { get; set; }
        public int Fiyat { get; set; }
        public bool Uyggunluk { get; set; }
        public bool Anasayfa { get; set; }
        public int CategoryId { get; set; }
    }
}