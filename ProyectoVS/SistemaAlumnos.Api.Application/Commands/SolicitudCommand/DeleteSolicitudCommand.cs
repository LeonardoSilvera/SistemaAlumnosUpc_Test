using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Application.Commands.SolicitudCommand
{
    public class DeleteSolicitudCommand : IRequest<int>
    { 
        public int? solicitudId { get; set; }
    }
}
