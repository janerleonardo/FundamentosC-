using System.Collections.Generic;
using System;
namespace CoreEscuela.Entidades
{
    public class Curso : EntidadEscuela
    {
        public List<Alumno> Alumnos {set; get;}

        public List<Asignatura> Asignaturas {set; get;}

        public Jornada Jornada { get; set; }

        public Curso()
        {
           
        }
    }
}