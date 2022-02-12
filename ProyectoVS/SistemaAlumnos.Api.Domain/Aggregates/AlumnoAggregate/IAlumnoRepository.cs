using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Domain.Aggregates.AlumnoAggregate
{
    public interface IAlumnoRepository
    {

        Task<int> InsertUpdateAsync(Alumno alumno);
        Task<int> DeleteAsync(int alumnoId);


    }
}
