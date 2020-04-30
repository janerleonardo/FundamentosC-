using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela : EntidadEscuela, ILugar
    {
        public string Direccion {set; get;}
        public int AñoCreacion { get; set; }
        public string Ceo { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public TipoEscuela TipoEscuela { get; set; }

         public List<Curso> Cursos { get; set; }
        public Escuela(string Nombre, string Direccion, int AñoCreacion, string Ceo)
        {
            this.AñoCreacion = AñoCreacion;
            this.Ceo = Ceo;
            this.Direccion = Direccion;
            this.Nombre = Nombre;
        }
        //Constructor por tuplas
        /// <summary>
        ///  Contructor por tuplas  es otra forma de crear un contructor
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="AñoCreacion"></param>
        /// <returns></returns>
        public Escuela(string Nombre, int AñoCreacion) => 
        (Nombre, AñoCreacion) = (Nombre,AñoCreacion);
        
        public Escuela(string Nombre, int AñoCreacion, 
                            TipoEscuela TipoEscuela, string Pais= "", string Ciudad= "")
        {
            this.Nombre = Nombre;
            this.AñoCreacion = AñoCreacion;
            this.TipoEscuela = TipoEscuela;
            this.Pais = Pais;
            this.Ciudad = Ciudad;
        }

        public void Timbrar()
        {
            Console.Beep(3000,3000);
            
        }

        public void Imprimir()
        {
            Console.WriteLine(string.Format("Escuela {0}, Ceo {1}, Año de Creacion {2}",Nombre,Ceo,AñoCreacion));
            Console.WriteLine($"Escuela {Nombre}, Ceo {Ceo} {System.Environment.NewLine}, Año de Creacion {AñoCreacion}");
            
        }

        public void LimpiarDireccion()
        {
            throw new NotImplementedException();
        }
    }
}