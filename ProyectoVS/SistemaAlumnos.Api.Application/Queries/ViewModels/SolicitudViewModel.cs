using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Application.Queries.ViewModels
{
    public class SolicitudViewModel
    { 
        public int idSolicitud { get; set; }
        public int idAlumno { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public string codRegistrante { get; set; } 
        public string carrera { get; set; }
        public string periodo { get; set; }

    }
}
