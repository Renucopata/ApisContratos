using System.Data.SqlClient;

namespace ApisContratos.Handlers
{
    public class Connections
    {
        private readonly IConfiguration _configuration;

        public Connections(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SqlConnection getContratosConnection ()
        {
            return new SqlConnection(_configuration.GetConnectionString("ConexionContratos").ToString());
                
        }

        public SqlConnection getStageConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("ConexionStage").ToString());

        }
    }
}
