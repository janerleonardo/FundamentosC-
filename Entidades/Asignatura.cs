using System.Security.AccessControl;
using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Asignatura : EntidadEscuela
    {
        
        public List<Evaluacion> Evaluaciones { get; set; }
        public Asignatura()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}