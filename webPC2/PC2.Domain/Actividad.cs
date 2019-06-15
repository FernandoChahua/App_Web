using System;

namespace PC2.Domain
{
    public class Actividad
    {
        public int IdActividad{get;set;}
        public string Descripcion{get;set;}
        public string Prioridad{get;set;}
        public DateTime FechaInicio{get;set;}
        public DateTime FechaFin{get;set;}
        public int Estado{get;set;}
        public string Programador{get;set;}
        public int IdProyecto { get; set; }
        public Proyecto Proyecto{get;set;}
    }
}
