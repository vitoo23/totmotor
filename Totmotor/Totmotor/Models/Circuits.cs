using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TotMotor.Models
{
    public class Circuits
    {

        public int ID { get; set; }
        public string Nom_Circuit { get; set; }
        public string Pais { get; set; }
        public string Bandera_Pais { get; set; }
        public int Quilòmetres { get; set; }
        public int Any_Construcció { get; set; }
        public int Num_Corbes { get; set; }
        public string Descripció { get; set; }


    }
}