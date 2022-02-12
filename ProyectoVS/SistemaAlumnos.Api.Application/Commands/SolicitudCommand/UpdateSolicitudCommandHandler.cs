using SistemaAlumnos.Api.Domain.Aggregates.SolicitudAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaAlumnos.Api.Application.Commands.SolicitudCommand
{
    public  class UpdateSolicitudCommandHandler
    { 

        readonly ISolicitudRepository _iSolicitudRepository;

        public UpdateSolicitudCommandHandler(ISolicitudRepository iSolicitudRepository)
        {
            _iSolicitudRepository = iSolicitudRepository;
        }

        public async Task<int> Handle(UpdateSolicitudCommand  request) //, CancellationToken cancellationToken
        {
            Solicitud solicitud = new Solicitud(request.idSolicitud ?? 0,
                request.idAlumno ?? 0,
                request.fechaSolicitud ?? new DateTime(),
                request.codRegistrante ?? String.Empty,
                request.carrera ?? String.Empty,
                request.periodo ?? String.Empty);
             
            var result = await _iSolicitudRepository.InsertUpdateAsync(solicitud);

            return result;
        }


    }
}
