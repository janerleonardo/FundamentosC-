using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno : EntidadEscuela
    {
        public List<Asignatura> Asignaturas { get; set; }

        public Curso Curso   { get; set; }

        public Alumno()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}