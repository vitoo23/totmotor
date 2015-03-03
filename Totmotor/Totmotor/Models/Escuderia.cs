using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TotMotor.Models
{
    public class Escuderia
    {

        public int ID { get; set; }
        public string Nom { get; set; }
        public string Logotip { get; set; }
        public string Descripció { get; set; }
        public Pilot nom_pilot { get; set; }
        public string nom_pilotID { get; set; }

        public virtual ICollection<Pilot> Pilots { get; set; }

    }
}