using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TotMotor.Models
{
    public class Pilot
    {

        public int ID { get; set; }
        public string Nom_pilot { get; set; }
        public string Cognoms { get; set; }
        public int Edat { get; set; }
        public string Nacionalitat { get; set; }
        public string Descripció { get; set; }
        public Escuderia escuderia { get; set; }
        public int escuderiaID { get; set; }

        public virtual ICollection<Escuderia> Escuderias { get; set; }

    }
}