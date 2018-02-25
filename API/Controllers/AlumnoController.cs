using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace API.Controllers
{
    public class AlumnoController : ApiController
    {
        Alumno CurrAlumno = new Alumno();
        public List<Alumno> Get()
        {
           return CurrAlumno.obtenerTodosLosAlumnos();
        } 
    }
}
