using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TotMotor.Models
{
    public class TotMotorContext : DbContext
    {

        public DbSet<Escuderia> Escuderias { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Noticies> Noticies { get; set; }
        public DbSet<Circuits> Circuits { get; set; }
        public DbSet<Contacte> Contacte { get; set; }
        public DbSet<Wiki> Wiki { get; set; }
        public DbSet<Aprendre> Aprendre { get; set; }

    }
}
