using System.Text;
using System;
namespace CoreEscuela.Entidades
{
    public abstract class EntidadEscuela
    {
        public string Id { get; set; }

        public string Nombre { get; set; }

        public EntidadEscuela()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre}, {Id}";
        }

    }
}