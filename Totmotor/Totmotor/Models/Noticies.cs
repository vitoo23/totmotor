using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TotMotor.Models
{
    public class Noticies
    {

        public int ID { get; set; }
        public string Títol { get; set; }
        public string Contingut { get; set; }
        public DateTime Data_publicació { get; set; }
        public string Autor_Noticia { get; set; }


    }
}