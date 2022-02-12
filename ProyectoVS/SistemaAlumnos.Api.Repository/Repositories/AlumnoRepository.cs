using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaAlumnos.Api.Domain.Aggregates.AlumnoAggregate;

namespace SistemaAlumnos.Api.Repository.Repositories
{
    public class AlumnoRepository : IAlumnoRepository
    {

        readonly string _connectionString = string.Empty;

        public AlumnoRepository() {

            _connectionString = "Data Source=.;Initial Catalog=SistemaAlumnosUPC;User Id=sa;Password=123456";
        
        }

        public async Task<int> InsertUpdateAsync(Alumno alumno)
        {
            try
            {

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    var parameters = new DynamicParameters();

                    //INSERT : Debe ingresar el campo alumnoId = 0
                    //UPDATE : Debe ingresar un id
                    parameters.Add("@IdAlumno", alumno.alumnoId, DbType.Int32, direction: ParameterDirection.InputOutput);
                    parameters.Add("@Nombres", alumno.alumnoNombres ?? String.Empty, DbType.String);
                    parameters.Add("@Apellidos", alumno.alumnoApellidos ?? String.Empty, DbType.String);
                 
                    var result = await connection.QueryAsync("sp_insert_alumno", parameters, commandType: CommandType.StoredProcedure);
                    var _idAlumno = parameters.Get<int>("@IdAlumno");
                    return Convert.ToInt32(_idAlumno);
                }
            }
            catch (Exception ex)
            { 
                throw;
            }
        }

        public async Task<int> DeleteAsync(int alumnoId)
        {
            try
            {

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    var parameters = new DynamicParameters();

                    parameters.Add("@IdAlumno", alumnoId, DbType.Int32); 

                    var result = await connection.QueryAsync("sp_delete_alumno", parameters, commandType: CommandType.StoredProcedure);
                    
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
