using System.Runtime.InteropServices.ComTypes;
using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi","Ave siempre viva",2020,"Janer");
            escuela.Cursos = new List<Curso>(){
                        new Curso(){ Nombre = "101", Jornada = Jornada.Mañana },
                        new Curso() {Nombre = "201", Jornada = Jornada.Mañana},
                        new Curso() {Nombre = "301", Jornada = Jornada.Tarde},
                        new Curso() {Nombre = "311", Jornada = Jornada.Tarde},
                        new Curso() {Nombre = "312", Jornada = Jornada.Tarde},
                        new Curso() {Nombre = "313", Jornada = Jornada.Tarde},
                        new Curso() {Nombre = "401", Jornada = Jornada.Noche},
                        new Curso() {Nombre = "501", Jornada = Jornada.Mañana},
                        new Curso() {Nombre = "601", Jornada = Jornada.Tarde},
                        new Curso {  Nombre = "701", Jornada = Jornada.Noche}
            };

            //Forma de elimina un registro de la lista utilizando un  predicado 
            escuela.Cursos.RemoveAll(Predicate);
            // Forma de eliminar utilizando un Delegado
            escuela.Cursos.RemoveAll(delegate(Curso curso) {
                return curso.Nombre == "312";
            });
            //Forma de eliminar utilizando expresiones lambda
            escuela.Cursos.RemoveAll((Curso cur) => cur.Nombre == "313" );
            ImpreCurso(escuela.Cursos);
           
            

        }

        private static bool Predicate(Curso obj)
        {
            return obj.Nombre == "311";
        }

        public static void ImpreCurso(List<Curso> listCurso)
        {

            foreach (var item in listCurso)
            {
                //Formas de Impresion
                 System.Console.WriteLine(string.Format("Curso:  {0}, Id: {1}, \n Jornada {2}", item.Nombre,item.Id,item.Jornada));
                 System.Console.WriteLine($"Curso {item.Nombre}, \n Id {item.Id}, {System.Environment.NewLine} Jornada {item.Jornada}");
            }
        }

        public void Escuelitas()
        {
            //Contructor por tuplas
            var escuela2 = new Escuela("Pruebas",2020);
            escuela2.Timbrar();

            //Contructor por Parametrso  Default
            var escuela3 = new Escuela("Deporte", 2020,TipoEscuela.Primaria, Pais:"Colombia");
            escuela3.Timbrar();

            var escuela4 = new Escuela("Deporte", 2020,TipoEscuela.Primaria, Ciudad:"Bogota");
            escuela4.Timbrar();

            //Cambio  de orden
            var escuela5 = new Escuela("Deporte", 2020,TipoEscuela.Primaria, Ciudad:"Londres", Pais:"ENG");
            escuela4.Timbrar();
        }
    }
}
