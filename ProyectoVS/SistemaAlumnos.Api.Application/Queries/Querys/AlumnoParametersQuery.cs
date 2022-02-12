using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Application.Queries.Querys
{
    public class AlumnoParametersQuery
    {
        public int? alumnoId { get; set; }
        public string? alumnoNombres { get; set; }
        public string? alumnoApellidos { get; set; }
    }
}
