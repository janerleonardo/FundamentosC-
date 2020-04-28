using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno : EntidadEscuela
    {
        public List<Asignatura> Asignaturas { get; set; }

        public List<Evaluacion> Evaluciones { get; set; } = new  List<Evaluacion>();

        public Curso Curso   { get; set; }

        public Alumno()
        {

        }
    }
}