using System;
using System.Collections.Generic;

namespace PC2.Domain
{
    public class Proyecto
    {
        public int IdProyecto {get;set;}
        public string Nombre{get;set;}
        public string Descripcion{get;set;}
        public DateTime FechaInicio{get;set;}
        public DateTime FechaFin{get;set;}
        
    }
}
