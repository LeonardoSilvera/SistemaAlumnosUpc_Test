using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Application.Queries.Querys
{
    public class SolicitudParametersQuery
    {
        public int? solicitudId { get; set; }
        public int? alumnoId { get; set; }
        public string? fechaSolicitud { get; set; }
        public string? codRegistrante { get; set; }
        public string? carrera { get; set; }
        public string? periodo { get; set; }
    }
}
