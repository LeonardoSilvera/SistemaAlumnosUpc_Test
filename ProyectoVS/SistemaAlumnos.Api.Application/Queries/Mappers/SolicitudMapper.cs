using SistemaAlumnos.Api.Application.Queries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Application.Queries.Mappers
{

    public interface ISolicitudMapper
    {
        SolicitudViewModel MapToSolicitudViewModel(dynamic r);
    }
    public class SolicitudMapper : ISolicitudMapper
    {
        public SolicitudViewModel MapToSolicitudViewModel(dynamic r)
        {
            SolicitudViewModel o = new SolicitudViewModel();

            o.idSolicitud = r.IdSolicitud;
            o.idAlumno = r.IdAlumno;
            o.fechaSolicitud = r.FechaSolicitud;
            o.codRegistrante = r.CodRegistrante;
            o.carrera = r.Carrera;
            o.periodo = r.Periodo;

            return o;
        }
    }
}
