using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Application.Commands.SolicitudCommand
{
    public class UpdateSolicitudCommand : IRequest<int>
    {

        public int? idSolicitud { get; set; }
        public int? idAlumno { get; set; }
        public DateTime? fechaSolicitud { get; set; }
        public string? codRegistrante { get; set; }
        public string? carrera { get; set; }
        public string? periodo { get; set; }

    }
}
