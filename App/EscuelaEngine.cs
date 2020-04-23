using System.Collections.Generic;
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

        }


    }
}