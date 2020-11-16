using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RentAcar_SG.Models
{
    public class VehicleContext:DbContext
    {
        public VehicleContext():base("RentAcarSG")
        {
            Database.SetInitializer(new VehicleInitializer());
        }


        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MyAdmin> MyAdmins { get; set; }
        public DbSet<Login> Logins { get; set; }

    }
}