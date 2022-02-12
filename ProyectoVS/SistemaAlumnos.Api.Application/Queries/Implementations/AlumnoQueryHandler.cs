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
    public class AlumnoQueryHandler : IAlumnoQueryHandler
    {
        readonly string _connectionString;
        readonly IAlumnoMapper _iAlumnoMapper;

        public AlumnoQueryHandler() {
            _connectionString = "Data Source=.;Initial Catalog=SistemaAlumnosUPC;User Id=sa;Password=123456";
            _iAlumnoMapper = new AlumnoMapper();
        }

       public  async Task<IEnumerable<AlumnoViewModel>> Search(AlumnoParametersQuery alumnoQuery)
        {
            try
            {

                using (var connection = new SqlConnection(_connectionString) ) 
                { 
                    connection.Open();

                    var parameters = new DynamicParameters();
                    parameters.Add("@IdAlumno",alumnoQuery.alumnoId??0,DbType.Int32);
                    parameters.Add("@Nombres", alumnoQuery.alumnoNombres??String.Empty, DbType.String); 
                    parameters.Add("@Apellidos", alumnoQuery.alumnoApellidos??String.Empty, DbType.String);

                    var searchResults = await connection.QueryAsync<dynamic>("sp_get_alumno",parameters,commandType: CommandType.StoredProcedure);

                    return searchResults.Select(item => (AlumnoViewModel) _iAlumnoMapper.MapToAlumnoViewModel(item) ); 

                }

            }
            catch (Exception ex)
            { 
                throw ;
            } 
        }

       public async Task<IEnumerable<AlumnoViewModel>> SearchById(int alumnoId)
        {
            try
            {

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var parameters = new DynamicParameters();
                    parameters.Add("@IdAlumno", alumnoId, DbType.Int32);
                    parameters.Add("@Nombres",   String.Empty, DbType.String);
                    parameters.Add("@Apellidos",  String.Empty, DbType.String);

                    var searchResults = await connection.QueryAsync<dynamic>("sp_get_alumno", parameters, commandType: CommandType.StoredProcedure);

                    return searchResults.Select(item => (AlumnoViewModel)_iAlumnoMapper.MapToAlumnoViewModel(item));

                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
