using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 
using SistemaAlumnos.Api.Application.Queries.Interfaces;
using SistemaAlumnos.Api.Application.Queries.ViewModels;
using SistemaAlumnos.Api.Application.Queries.Querys;
using SistemaAlumnos.Api.Application.Queries.Implementations;
using System.Net;
using SistemaAlumnos.Api.Application.Commands.AlumnoCommand; 
using MediatR;
using SistemaAlumnos.Api.Domain.Aggregates.AlumnoAggregate;
using SistemaAlumnos.Api.Repository.Repositories;

namespace SistemaAlumnos.Api.Controllers
{
    [ApiController]
    [Route("controller/alumno")]
    public class AlumnoController : ControllerBase
    { 
        private IAlumnoQueryHandler _iAlumnoQueryHandler;
        private CreateAlumnoCommandHandler _creatAlumnoCommandHandler;
        private UpdateAlumnoCommandHandler _updateAlumnoCommandHandler;
        private DeleteAlumnoCommandHandler _deleteAlumnoCommandHandler;

        public AlumnoController()
        { 
            //En una arquitectura de microservicios(Orientado al Dominio), se realiza la inyeccion de dependencia de las interfaces
            //y con ello se podra acceder a clases del repository o queryhandler sin necesidad de inicializarlas
            //Por motivo de tiempo no se ha modificado el "builder" para que pueda aceptar esta necesidad de inyeccion
            //por ello se llama directamente a la clase, pero se demuestra la intención.
             
            _iAlumnoQueryHandler =  new AlumnoQueryHandler();
            _creatAlumnoCommandHandler = new CreateAlumnoCommandHandler(new AlumnoRepository());
            _updateAlumnoCommandHandler = new UpdateAlumnoCommandHandler(new AlumnoRepository());
            _deleteAlumnoCommandHandler = new DeleteAlumnoCommandHandler(new AlumnoRepository());

        }

        [HttpGet(Name = "getAlumno")] 
        public async Task<IEnumerable<AlumnoViewModel>> Get([FromQuery] AlumnoParametersQuery obj)
        {
            var result = await _iAlumnoQueryHandler.Search(obj);
            return result;
        }

        [HttpGet]
        [Route("{alumnoId}")]
        public async Task<IEnumerable<AlumnoViewModel>> GetById( int alumnoId)
        {
            var result = await _iAlumnoQueryHandler.SearchById(alumnoId);
            return result;
        }

         
        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreateAlumnoCommand alumnoCommand)
        {
            var commandResult = await _creatAlumnoCommandHandler.Handle(alumnoCommand);
            //    var commandResult = await _mediator.Send(alumnoCommand);
              
            return CreatedAtAction(nameof(Create), commandResult);
        }

        [HttpPut]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Update([FromBody] UpdateAlumnoCommand alumnoCommand)
        {
            var commandResult = await _updateAlumnoCommandHandler.Handle(alumnoCommand);
            //    var commandResult = await _mediator.Send(alumnoCommand);

            return CreatedAtAction(nameof(Update), commandResult);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Delete([FromBody] DeleteAlumnoCommand alumnoCommand)
        {
            var commandResult = await _deleteAlumnoCommandHandler.Handle(alumnoCommand);
            //    var commandResult = await _mediator.Send(alumnoCommand);

            return CreatedAtAction(nameof(Delete), commandResult);
        }




    }
}
