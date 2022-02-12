using SistemaAlumnos.Api.Application.Queries.Interfaces;
using SistemaAlumnos.Api.Application.Queries.Querys;
using SistemaAlumnos.Api.Application.Queries.ViewModels;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAlumnos.Api.Application.Queries.Mappers;

namespace SistemaAlumnos.Api.Application.Queries.Implementations
{
    public class SolicitudQueryHandler : ISolicitudQueryHandler
    {
        readonly string _connectionString;
        readonly ISolicitudMapper _iSolicitudMapper;

        public SolicitudQueryHandler() {
            _connectionString = "Data Source=.;Initial Catalog=SistemaAlumnosUPC;User Id=sa;Password=123456";
            _iSolicitudMapper = new SolicitudMapper();
        }

       public  async Task<IEnumerable<SolicitudViewModel>> Search(SolicitudParametersQuery solicitudQuery)
        {
            try
            {

                using (var connection = new SqlConnection(_connectionString) ) 
                { 
                    connection.Open();

                    var parameters = new DynamicParameters();
                    parameters.Add("@IdSolicitud", solicitudQuery.solicitudId ?? 0,DbType.Int32);
                    parameters.Add("@IdAlumno", solicitudQuery.alumnoId ?? 0, DbType.Int32);
                    parameters.Add("@FechaSolicitud", null, DbType.DateTime); //solicitudQuery.fechaSolicitud ?? String.Empty
                    parameters.Add("@CodRegistrante", solicitudQuery.codRegistrante ?? String.Empty, DbType.String);
                    parameters.Add("@Carrera", solicitudQuery.carrera??String.Empty, DbType.String); 
                    parameters.Add("@Periodo", solicitudQuery.periodo??String.Empty, DbType.String);

                    var searchResults = await connection.QueryAsync<dynamic>("sp_get_solicitud", parameters,commandType: CommandType.StoredProcedure);

                    return searchResults.Select(item => (SolicitudViewModel)_iSolicitudMapper.MapToSolicitudViewModel(item) ); 

                }

            }
            catch (Exception ex)
            { 
                throw ;
            } 
        }

       public async Task<IEnumerable<SolicitudViewModel>> SearchById(int solicitudId)
        {
            try
            {

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var parameters = new DynamicParameters();
                    parameters.Add("@IdSolicitud", solicitudId, DbType.Int32);
                    parameters.Add("@IdAlumno", 0, DbType.Int32);
                    parameters.Add("@FechaSolicitud", null, DbType.DateTime); //solicitudQuery.fechaSolicitud ?? String.Empty
                    parameters.Add("@CodRegistrante",  String.Empty, DbType.String);
                    parameters.Add("@Carrera", String.Empty, DbType.String);
                    parameters.Add("@Periodo", String.Empty, DbType.String);

                    var searchResults = await connection.QueryAsync<dynamic>("sp_get_solicitud", parameters, commandType: CommandType.StoredProcedure);

                    return searchResults.Select(item => (SolicitudViewModel)_iSolicitudMapper.MapToSolicitudViewModel(item));

                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
