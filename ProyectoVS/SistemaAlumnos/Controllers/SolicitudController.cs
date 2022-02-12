using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaAlumnos.Api.Application.Queries.Interfaces;
using SistemaAlumnos.Api.Application.Queries.ViewModels;
using SistemaAlumnos.Api.Application.Queries.Querys;
using SistemaAlumnos.Api.Application.Queries.Implementations;
 
using System.Net;
using SistemaAlumnos.Api.Application.Commands.SolicitudCommand;
using MediatR;
using SistemaAlumnos.Api.Domain.Aggregates.SolicitudAggregate;
using SistemaAlumnos.Api.Repository.Repositories;

namespace SistemaAlumnos.Api.Controllers
{
    [ApiController]
    [Route("controller/solicitud")]
    public class SolicitudController : Controller
    { 
        ISolicitudQueryHandler _iSolicitudQueryHandler;
        private CreateSolicitudCommandHandler _creatAlumnoCommandHandler;
        private UpdateSolicitudCommandHandler _updateAlumnoCommandHandler;
        private DeleteSolicitudCommandHandler _deleteAlumnoCommandHandler;

        public SolicitudController()
        { 
            _iSolicitudQueryHandler = new SolicitudQueryHandler();
            _creatAlumnoCommandHandler = new CreateSolicitudCommandHandler(new SolicitudRepository());
            _updateAlumnoCommandHandler = new UpdateSolicitudCommandHandler(new SolicitudRepository());
            _deleteAlumnoCommandHandler = new DeleteSolicitudCommandHandler(new SolicitudRepository());
        }

        [HttpGet(Name = "getSolicitud")]
        public async Task<IEnumerable<SolicitudViewModel>> Get([FromQuery] SolicitudParametersQuery obj)
        {
            var result = await _iSolicitudQueryHandler.Search(obj);
            return result;
        }

        [HttpGet]
        [Route("{solicitudId}")]
        public async Task<IEnumerable<SolicitudViewModel>> GetById(int solicitudId)
        {
            var result = await _iSolicitudQueryHandler.SearchById(solicitudId);
            return result;
        }
         


        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreateSolicitudCommand solicitudCommand)
        {
            var commandResult = await _creatAlumnoCommandHandler.Handle(solicitudCommand);
            //    var commandResult = await _mediator.Send(alumnoCommand);

            return CreatedAtAction(nameof(Create), commandResult);
        }

        [HttpPut]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Update([FromBody] UpdateSolicitudCommand solicitudCommand)
        {
            var commandResult = await _updateAlumnoCommandHandler.Handle(solicitudCommand);
            //    var commandResult = await _mediator.Send(alumnoCommand);

            return CreatedAtAction(nameof(Update), commandResult);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Delete([FromBody] DeleteSolicitudCommand solicitudCommand)
        {
            var commandResult = await _deleteAlumnoCommandHandler.Handle(solicitudCommand);
            //    var commandResult = await _mediator.Send(alumnoCommand);

            return CreatedAtAction(nameof(Delete), commandResult);
        }







    }
}
