
using SistemaAlumnos.Api.Domain.Aggregates.SolicitudAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Application.Commands.SolicitudCommand
{
    public class DeleteSolicitudCommandHandler
    {
         readonly ISolicitudRepository _iSolicitudRepository;

        public DeleteSolicitudCommandHandler(ISolicitudRepository iSolicitudRepository)
        {
            _iSolicitudRepository = iSolicitudRepository;
        }

        public async Task<int> Handle(DeleteSolicitudCommand request) //, CancellationToken cancellationToken
        { 
            var result = await _iSolicitudRepository.DeleteAsync(request.solicitudId ?? 0);

            return result;
        }


    }
}
