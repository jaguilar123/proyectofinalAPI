using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.Models;

namespace API.Controllers
{
    public class Alumno
    {
        private  AlumnoModel data = new AlumnoModel();

        public int id { get; set; } // forma uno
        public string nombre { get; set; }

        public string Apellido { get; set; }

        public List<Alumno> obtenerTodosLosAlumnos()
        {
            return data.obtenerAlumnos();
        }


        

    }
}