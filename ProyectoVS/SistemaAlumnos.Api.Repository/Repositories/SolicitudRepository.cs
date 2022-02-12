using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaAlumnos.Api.Domain.Aggregates.SolicitudAggregate;


namespace SistemaAlumnos.Api.Repository.Repositories
{
    public class SolicitudRepository : ISolicitudRepository
    {
        readonly string _connectionString = string.Empty;

        public SolicitudRepository()
        {
            _connectionString = "Data Source=.;Initial Catalog=SistemaAlumnosUPC;User Id=sa;Password=123456";
        }

        public async Task<int> InsertUpdateAsync(Solicitud solicitud)
        {
            try
            {

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    var parameters = new DynamicParameters();

                    //INSERT : Debe ingresar el campo alumnoId = 0
                    //UPDATE : Debe ingresar un id
                    parameters.Add("@IdSolicitud",  solicitud.idSolicitud , DbType.Int32, direction: ParameterDirection.InputOutput);
                    parameters.Add("@IdAlumno",   solicitud.idAlumno, DbType.String);
                    parameters.Add("@FechaSolicitud", solicitud.fechaSolicitud , DbType.DateTime);
                    parameters.Add("@CodRegistrante", solicitud.codRegistrante ?? String.Empty, DbType.String);
                    parameters.Add("@Carrera", solicitud.carrera ?? String.Empty, DbType.String);
                    parameters.Add("@Periodo", solicitud.periodo ?? String.Empty, DbType.String);

                    var result = await connection.QueryAsync("sp_insert_solicitud", parameters, commandType: CommandType.StoredProcedure);
                    var _idAlumno = parameters.Get<int>("@IdSolicitud");
                    return Convert.ToInt32(_idAlumno);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> DeleteAsync(int solicitudId)
        {
            try
            {

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    var parameters = new DynamicParameters();

                    parameters.Add("@IdSolicitud", solicitudId, DbType.Int32);

                    var result = await connection.QueryAsync("sp_delete_solicitud", parameters, commandType: CommandType.StoredProcedure);

                    return Convert.ToInt32(1);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
