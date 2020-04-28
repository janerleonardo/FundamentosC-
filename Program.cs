using System.Runtime.InteropServices.ComTypes;
using System;
using CoreEscuela.Entidades;
using CoreEscuela.App;
using System.Collections.Generic;
using CoreEscuela.Util;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
           
           var EscuelaEngine = new EscuelaEngine();
            EscuelaEngine.Inicializar();
            Impresion(EscuelaEngine.Escuela.Cursos);


           /* Busqueda(EscuelaEngine.Escuela.Cursos);
            ImpreCurso(EscuelaEngine.Escuela.Cursos);
            Printer.Dibujarlinea();*/

        }
        public static void Impresion(List<Curso> listCurso)
        {

            foreach (Curso curso in listCurso)
            {
                Printer.Dibujar();
                System.Console.WriteLine($"Curso: {curso.Nombre}");
                 Printer.Dibujar();
                 System.Console.WriteLine("");
                foreach (var asa in curso.Asignaturas)
                {
                    System.Console.WriteLine($"Asignatura: {asa.Nombre}");
                }
                Printer.Dibujar();
                 System.Console.WriteLine("");
                foreach (var al in curso.Alumnos)
                {
                    System.Console.WriteLine($"Alumno: {al.Nombre}");
                }
                
            }
        }


        private static void Busqueda(List<Curso> Cursos)
        {
            //Forma de elimina un registro de la lista utilizando un  predicado 
            Cursos.RemoveAll(Predicate);
            // Forma de eliminar utilizando un Delegado
            Cursos.RemoveAll(delegate (Curso curso)
            {
                return curso.Nombre == "312";
            });
            //Forma de eliminar utilizando expresiones lambda
            Cursos.RemoveAll((Curso cur) => cur.Nombre == "313");
        }

        private static bool Predicate(Curso obj)
        {
            return obj.Nombre == "311";
        }

        public static void ImpreCurso(List<Curso> listCurso)
        {

            foreach (var item in listCurso)
            {
                
                //Formas de Impresion con Enter \n
                System.Console.WriteLine(string.Format("Curso:  {0}, Id: {1}, \n Jornada {2}", item.Nombre, item.Id, item.Jornada));
                  //Formas de Impresion con Enter System.Environment.NewLine
                System.Console.WriteLine($"Curso {item.Nombre}, \n Id {item.Id}, {System.Environment.NewLine} Jornada {item.Jornada}");
                        
                System.Console.WriteLine($"Curso {item.Nombre}, \n Id {item.Id}, Jornada {item.Jornada}");
            }
        }

        public void Escuelitas()
        {
            //Contructor por tuplas
            var escuela2 = new Escuela("Pruebas", 2020);
            escuela2.Timbrar();

            //Contructor por Parametrso  Default
            var escuela3 = new Escuela("Deporte", 2020, TipoEscuela.Primaria, Pais: "Colombia");
            escuela3.Timbrar();

            var escuela4 = new Escuela("Deporte", 2020, TipoEscuela.Primaria, Ciudad: "Bogota");
            escuela4.Timbrar();

            //Cambio  de orden
            var escuela5 = new Escuela("Deporte", 2020, TipoEscuela.Primaria, Ciudad: "Londres", Pais: "ENG");
            escuela4.Timbrar();
        }
    }
}
