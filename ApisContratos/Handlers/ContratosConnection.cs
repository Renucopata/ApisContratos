namespace ApisContratos.Handlers
{
    public class ContratosConnection
    {

        private String cadConexion = String.Empty;
        public ContratosConnection()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cadConexion = builder.GetSection("ConnectionStrings:ConexionContratos").Value;
        }
        public String get_cadConexion()
        {
            return cadConexion;
        }
    }
}
