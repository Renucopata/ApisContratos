namespace ApisContratos.Handlers
{
    public class StageConnection
    {

        private String cadConexion = String.Empty;
        public StageConnection()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cadConexion = builder.GetSection("ConnectionStrings:ConexionStage").Value;
        }
        public String get_cadConexion()
        {
            return cadConexion;
        }
    }
}
