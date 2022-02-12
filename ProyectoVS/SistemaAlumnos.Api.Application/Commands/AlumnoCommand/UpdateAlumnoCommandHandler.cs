using SistemaAlumnos.Api.Domain.Aggregates.AlumnoAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Application.Commands.AlumnoCommand
{
    public  class UpdateAlumnoCommandHandler
    { 
        readonly IAlumnoRepository _iAlumnoRepository;

        public UpdateAlumnoCommandHandler(IAlumnoRepository iAlumnoRepository)
        {
            _iAlumnoRepository = iAlumnoRepository;
        }

        public async Task<int> Handle(UpdateAlumnoCommand request) //, CancellationToken cancellationToken
        {
            //Alumno alumno
            Alumno alumno = new Alumno(request.alumnoId ?? 0, request.alumnoNombres ?? String.Empty, request.alumnoApellidos ?? String.Empty);

            var result = await _iAlumnoRepository.InsertUpdateAsync(alumno);

            return result;
        }


    }
}
