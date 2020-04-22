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
           
            

        }

        public void Cursitos(string parameter)
        {
            var curso = new Curso(){
                Nombre = "101",
                Jornada = Jornada.Mañana
            };
            var curso1 = new Curso(){
                Nombre = "201",
                Jornada = Jornada.Tarde
            };
            var curso2 = new Curso(){
                Nombre = "301",
                Jornada = Jornada.Tarde
            };
            var curso3 = new Curso(){
                Nombre = "401",
                Jornada = Jornada.Tarde
            };
            var curso4 = new Curso(){
                Nombre = "401"
            };
            List<Curso> listCurso = new List<Curso>(){curso,curso1,curso2,curso3,curso4};

            foreach (var item in listCurso)
            {
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
