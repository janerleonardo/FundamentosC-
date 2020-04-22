using System;
namespace CoreEscuela.Entidades
{
    public class Curso
    {

        public string Nombre { get; set; }
        public string Id { get; private set; }

        public Jornada Jornada { get; set; }

        public Curso()
        {
            Id =  Guid.NewGuid().ToString();
        }
    }
}