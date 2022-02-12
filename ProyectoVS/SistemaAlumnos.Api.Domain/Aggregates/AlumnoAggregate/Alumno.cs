using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Domain.Aggregates.AlumnoAggregate
{
    public class Alumno
    { 
        public int alumnoId { get; set; }
        public string alumnoNombres { get; set; }
        public string alumnoApellidos { get; set; }

        public Alumno(int alumnoId,
            string alumnoNombres,
            string alumnoApellidos) { 

            this.alumnoId = alumnoId;
            this.alumnoNombres = alumnoNombres;
            this.alumnoApellidos = alumnoApellidos;
        
        }

        public Alumno( 
            string alumnoNombres,
            string alumnoApellidos)
        { 
            this.alumnoNombres = alumnoNombres;
            this.alumnoApellidos = alumnoApellidos;

        }
    }
}
