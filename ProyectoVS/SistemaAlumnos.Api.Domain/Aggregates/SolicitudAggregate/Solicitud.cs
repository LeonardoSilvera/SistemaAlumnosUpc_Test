using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Domain.Aggregates.SolicitudAggregate
{
    public class Solicitud
    { 

        public int idSolicitud { get; set; }
        public int idAlumno { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public string codRegistrante { get; set; }
        public string carrera { get; set; }
        public string periodo { get; set; }


        public Solicitud(int idSolicitud,
            int idAlumno,
            DateTime fechaSolicitud,
            string codRegistrante,
            string carrera, 
            string periodo) { 

            this.idSolicitud = idSolicitud;
            this.idAlumno = idAlumno;
            this.fechaSolicitud = fechaSolicitud;
            this.codRegistrante = codRegistrante;
            this.carrera = carrera;
            this.periodo = periodo; 
             
        }

        public Solicitud( 
            int idAlumno,
            DateTime fechaSolicitud,
            string codRegistrante,
            string carrera,
            string periodo)
        {
             
            this.idAlumno = idAlumno;
            this.fechaSolicitud = fechaSolicitud;
            this.codRegistrante = codRegistrante;
            this.carrera = carrera;
            this.periodo = periodo;

        }




    }
}
