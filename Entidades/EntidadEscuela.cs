using System;
namespace CoreEscuela.Entidades
{
    public class EntidadEscuela
    {
        public string Id { get; set; }

        public string Nombre { get; set; }

        public EntidadEscuela()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}