using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RentAcar_SG.Models
{
    public class VehicleInitializer: DropCreateDatabaseAlways<VehicleContext>
    {

        protected override void Seed(VehicleContext context)
        {

            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="Otomobil"},
                new Category(){KategoriAdi="Motorsiklet"},

            };

            foreach (var item in kategoriler)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();

            List<Vehicle> araclar = new List<Vehicle>()
            {
                new Vehicle(){AracAdi="Volvo",ModelAdi="S60",ModelYili="2015",Resim="/KiralikAraclar/1-VolvoS60.jpg",Fiyat=400,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Volvo",ModelAdi="S40",ModelYili="2013",Resim="/KiralikAraclar/2-VolvoS40.jpg",Fiyat=350,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Volkswagen",ModelAdi="Polo",ModelYili="2015",Resim="/KiralikAraclar/3-Polo2017.jpg",Fiyat=200,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Volkswagen",ModelAdi="Jetta",ModelYili="2017",Resim="/KiralikAraclar/4-jetta2015.jpg",Fiyat=250,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Volkswagen",ModelAdi="Passat",ModelYili="2015",Resim="/KiralikAraclar/5-2015-Passat.jpg",Fiyat=275,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Volkswagen",ModelAdi="Tiguan",ModelYili="2015",Resim="/KiralikAraclar/6-Tiguan-2015.jpg",Fiyat=300,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Renault",ModelAdi="Clio",ModelYili="2018",Resim="/KiralikAraclar/7-Renault2018.jpg",Fiyat=180,Uyggunluk=false,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Renault",ModelAdi="Clio",ModelYili="2015",Resim="/KiralikAraclar/8-Renault2015.jpg",Fiyat=150,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Renault",ModelAdi="Megane",ModelYili="2018",Resim="/KiralikAraclar/9-Megane2018.jpg",Fiyat=400,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Mercedes",ModelAdi="C180",ModelYili="2015",Resim="/KiralikAraclar/10-Mercedes180-2015.jpg",Fiyat=400,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Dacia",ModelAdi="Duster",ModelYili="2017",Resim="/KiralikAraclar/11-Dacia2017.jpg",Fiyat=180,Uyggunluk=false,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Opel",ModelAdi="Corsa",ModelYili="2018",Resim="/KiralikAraclar/12-Corsa2018.jpg",Fiyat=220,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="Opel",ModelAdi="Astra",ModelYili="2015",Resim="/KiralikAraclar/13-AStra2015.jpg",Fiyat=275,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="BMW",ModelAdi="520d",ModelYili="2015",Resim="/KiralikAraclar/14-BMW520-2015.jpg",Fiyat=400,Uyggunluk=true,Anasayfa=true,CategoryId=1},
                new Vehicle(){AracAdi="BMW",ModelAdi="S100R",ModelYili="2015",Resim="/KiralikAraclar/15-S100R-2015.jpg",Fiyat=400,Uyggunluk=true,Anasayfa=true,CategoryId=2},
                new Vehicle(){AracAdi="Kawasaki",ModelAdi="Ninja-ZX-6R",ModelYili="2015",Resim="/KiralikAraclar/16-KawazakiNinja2015.jpg",Fiyat=350,Uyggunluk=true,Anasayfa=true,CategoryId=2},
                new Vehicle(){AracAdi="Yamaha",ModelAdi="MT-09",ModelYili="2015",Resim="/KiralikAraclar/17-YAMAHAMT09-2015.jpg",Fiyat=250,Uyggunluk=false,Anasayfa=true,CategoryId=2},
            };

            foreach (var item in araclar)
            {
                context.Vehicles.Add(item);
            }

            context.SaveChanges();

            List<MyAdmin> admins = new List<MyAdmin>()
            {
                new MyAdmin(){name="adem",passwd="admin"},
                new MyAdmin(){name="sitem",passwd="sitem" },

            };

            foreach (var item in admins)
            {
                context.MyAdmins.Add(item);
            }

            context.SaveChanges();

            List<Login> logins = new List<Login>()
            {
                new Login(){username="adem",password="adem"},
                new Login(){username="sitem",password="sitem" },

            };

            foreach (var item in logins)
            {
                context.Logins.Add(item);
            }

            context.SaveChanges();


            base.Seed(context);
        }

    }
}