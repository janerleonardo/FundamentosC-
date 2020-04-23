using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Evaluacion : EntidadEscuela
    {

        public Alumno Alumno { get; set; }

        public List<Periodos> Periodos { get; set; }

        public Evaluacion()
        {
            Id= Guid.NewGuid().ToString();
        }
    }
}