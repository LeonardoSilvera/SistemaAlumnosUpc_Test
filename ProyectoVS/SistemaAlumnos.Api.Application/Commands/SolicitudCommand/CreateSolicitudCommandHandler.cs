using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using SistemaAlumnos.Api.Domain.Aggregates.SolicitudAggregate;

namespace SistemaAlumnos.Api.Application.Commands.SolicitudCommand
{
    public class CreateSolicitudCommandHandler //: IRequestHandler<CreateSolicitudCommand, int>
    {

        readonly ISolicitudRepository _iSolicitudRepository;

        public CreateSolicitudCommandHandler(ISolicitudRepository iSolicitudRepository)
        {
            _iSolicitudRepository = iSolicitudRepository;
        }

        public async Task<int> Handle(CreateSolicitudCommand request) //, CancellationToken cancellationToken
        { 
            Solicitud solicitud = new Solicitud( 
                request.idAlumno??0,
                request.fechaSolicitud??new DateTime(), 
                request.codRegistrante??String.Empty, 
                request.carrera ?? String.Empty , 
                request.periodo ?? String.Empty);

            var result = await _iSolicitudRepository.InsertUpdateAsync(solicitud);

            return result;
        }
    }
}
