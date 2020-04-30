using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Evaluacion : EntidadEscuela
    {

        public Alumno Alumno { get; set; }

         public Asignatura Asignatura { get; set; }

        public List<Periodos> Periodos { get; set; }

        public Double Nota { get; set; }

        public Evaluacion()
        {

        }
        public override string ToString() 
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}, {Periodos}";
        }
    }
}