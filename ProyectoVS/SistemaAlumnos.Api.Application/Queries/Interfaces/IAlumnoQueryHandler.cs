using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAlumnos.Api.Application.Queries.ViewModels;
using SistemaAlumnos.Api.Application.Queries.Querys;

namespace SistemaAlumnos.Api.Application.Queries.Interfaces
{
    public interface IAlumnoQueryHandler
    {
        Task<IEnumerable<AlumnoViewModel>> Search(AlumnoParametersQuery alumnoQuery);
        Task<IEnumerable<AlumnoViewModel>> SearchById(int alumnoId);

    }
}
