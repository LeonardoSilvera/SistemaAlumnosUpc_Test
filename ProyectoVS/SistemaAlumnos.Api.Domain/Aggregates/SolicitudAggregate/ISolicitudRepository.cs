using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos.Api.Domain.Aggregates.SolicitudAggregate
{
    public interface ISolicitudRepository
    {

        Task<int> InsertUpdateAsync(Solicitud solicitud);
        Task<int> DeleteAsync(int solicitudId);


    }
}
