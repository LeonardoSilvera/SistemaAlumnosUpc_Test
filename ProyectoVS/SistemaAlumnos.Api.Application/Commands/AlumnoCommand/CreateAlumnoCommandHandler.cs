using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAlumnos.Api.Domain.Aggregates.AlumnoAggregate;

namespace SistemaAlumnos.Api.Application.Commands.AlumnoCommand
{
    public class CreateAlumnoCommandHandler //: IRequestHandler<CreateAlumnoCommand, int>
    {

        readonly IAlumnoRepository _iAlumnoRepository;

        public CreateAlumnoCommandHandler(IAlumnoRepository iAlumnoRepository)
        {
            _iAlumnoRepository = iAlumnoRepository;
        }

        public async Task<int> Handle(CreateAlumnoCommand request) //, CancellationToken cancellationToken
        {
            //Alumno alumno
            Alumno alumno = new Alumno( request.alumnoNombres??String.Empty,request.alumnoApellidos??String.Empty);

            var result = await _iAlumnoRepository.InsertUpdateAsync(alumno);

            return result;
        }
    }
}
