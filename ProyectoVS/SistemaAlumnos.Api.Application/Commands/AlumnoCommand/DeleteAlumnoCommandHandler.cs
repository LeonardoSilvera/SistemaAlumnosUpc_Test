using SistemaAlumnos.Api.Domain.Aggregates.AlumnoAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Application.Commands.AlumnoCommand
{
    public class DeleteAlumnoCommandHandler
    {
         readonly IAlumnoRepository _iAlumnoRepository;

        public DeleteAlumnoCommandHandler(IAlumnoRepository iAlumnoRepository)
        {
            _iAlumnoRepository = iAlumnoRepository;
        }

        public async Task<int> Handle(DeleteAlumnoCommand request) //, CancellationToken cancellationToken
        { 
            var result = await _iAlumnoRepository.DeleteAsync(request.alumnoId??0);

            return result;
        }


    }
}
