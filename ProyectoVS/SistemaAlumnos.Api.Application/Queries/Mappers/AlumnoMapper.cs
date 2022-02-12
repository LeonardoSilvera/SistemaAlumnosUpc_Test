using SistemaAlumnos.Api.Application.Queries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Application.Queries.Mappers
{

    public interface IAlumnoMapper
    {
        AlumnoViewModel MapToAlumnoViewModel(dynamic r);
    }
    public class AlumnoMapper : IAlumnoMapper
    {
        public  AlumnoViewModel MapToAlumnoViewModel(dynamic r)
        {
            AlumnoViewModel o = new AlumnoViewModel();

            o.idAlumno = r.IdAlumno;
            o.nombres = r.Nombres;
            o.apellidos = r.Apellidos;

            return o;
        }
    }
}
