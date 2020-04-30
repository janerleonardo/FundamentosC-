using System.Collections.Generic;
using System;
namespace CoreEscuela.Entidades
{
    public class Curso : EntidadEscuela, ILugar
    {
        public List<Alumno> Alumnos {set; get;}

        public List<Asignatura> Asignaturas {set; get;}

        public Jornada Jornada { get; set; }
        public string Direccion { get ; set ; }

        public Curso()
        {
           
        }

        public void LimpiarDireccion()
        {
           System.Console.WriteLine("Implemntacion");
        }
    }
}