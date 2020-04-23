using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public EscuelaEngine(Escuela escuela)
        {
            this.Escuela = escuela;

        }
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {

        }
        public void Inicializar()
        {
            Escuela = new Escuela("Platzi", "Ave siempre viva", 2020, "Janer");
            CargarCurso();
            CargarAsignatura();
            //Escuela.Cursos.ForEach((Curso) => Curso.Alumnos.AddRange(GenerarAlumnos()));
           // CargarEvaluaciones();

        }

        private List<Alumno> GenerarAlumnos(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

           var  listaAlumno = from n1 in nombre1
                                       from n2 in nombre2
                                       from ap in apellido1
                                       select new Alumno () { Nombre = $"{n1} {n2} {ap}"};
            return listaAlumno.OrderBy((al) => al.Id).Take(cantidad).ToList();
                            
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignatura()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignatura = new List<Asignatura>() {
                    new Asignatura() { Nombre = "Matematicas"},
                    new Asignatura() { Nombre = "Programacion"},
                    new Asignatura() { Nombre = "Ofimatica"},
                    new Asignatura() { Nombre = "Castellano"},
                };

                curso.Asignaturas =  listaAsignatura;
            }
        }

        private void CargarCurso()
        {
            Escuela.Cursos = new List<Curso>(){
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
            
            foreach (var curso in Escuela.Cursos)
            {
                int cantRandon = new Random().Next(5,30);
                curso.Alumnos = GenerarAlumnos(cantRandon);
            }

        }
    }
}