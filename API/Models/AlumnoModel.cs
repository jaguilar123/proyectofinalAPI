using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.Conexion;
using API.Controllers;
using System.Data.SqlClient;
using System.Data;

namespace API.Models
{
    public class AlumnoModel
    {

        conexion coneccion = new conexion(new SqlConnection("Data Source= localhost; Initial Catalog= Escuela; Integrated Security=True"));

      
        conexion puerto = new conexion(new SqlConnection("Data Source= localhost; Initial Catalog= bd_configuracion; Integrated Security=True"));

     
        public List<Alumno> obtenerAlumnos() 
        {
            List<Alumno> clientes = new List<Alumno>();

            

            DataTable TABLA = puerto.get_data("SELECT 'SELECT ' + RTRIM(sd.nombre) + ' FROM ' + RTRIM(st.nombre) + ' ' + sw.nombre FROM tabla st inner join campos sd on st.id = sd.id_tabla inner join where1 sw on st.id = sw.id_tabla WHERE st.id = 1");

            DataTable datos = coneccion.get_data(TABLA.Rows[0].ItemArray[0].ToString());

            
            foreach (DataRow x in datos.Rows)
            {
                Alumno currAlumnos = new Alumno();

                currAlumnos.id = (int) x.ItemArray[0];
                currAlumnos.nombre = (string) x.ItemArray[1];
                currAlumnos.Apellido = (string)x.ItemArray[2];

                clientes.Add(currAlumnos);

            }

            return clientes;

        }


    }
}