using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejemploLINQ.Models
{
    public class Estudiantes
    {
        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double Promedio { get; set; }
        public DateTime FechaRegistro { get; set; }

        public List<Estudiantes> Lista()
        {
            var estudiante1 = new Estudiantes()
            {
                Carnet = 001,
                Nombre ="Maria",
                Materia = "gestion bases de datos",
                Promedio = 8.5,
                FechaRegistro = DateTime.Now
            };
            var estudiante2 = new Estudiantes()
            {
                Carnet = 002,
                Nombre ="Juan",
                Materia = "Linq",
                Promedio = 6,
                FechaRegistro = DateTime.Now
            };
            var estudiante3 = new Estudiantes()
            {
                Carnet = 003,
                Nombre = "Pedro",
                Materia = "Matematica",
                Promedio = 4,
                FechaRegistro = DateTime.Now
            };
            var estudiante4 = new Estudiantes()
            {
                Carnet = 004,
                Nombre = "Lorena",
                Materia = "Linq",
                Promedio = 6.5,
                FechaRegistro = DateTime.Now
            };
            return new List<Estudiantes>() {estudiante1, estudiante2, estudiante3, estudiante4 };
        }
    }

   
}