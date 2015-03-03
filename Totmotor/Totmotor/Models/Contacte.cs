using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TotMotor.Models
{
    public class Contacte
    {

        public int ID { get; set; }
        public string Email { get; set; }
        public int Telèfon { get; set; }
        public string Direcció { get; set; }
        public int Codi_Postal { get; set; }
        public string Població { get; set; }
        public string Pais { get; set; }

    }
}