using Oracle.ManagedDataAccess.Client;

public class DBConnection
{
    private readonly IConfiguration _configuration;
    private OracleConnection connection;
    
    public DBConnection()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        _configuration = configuration;
        //this.connection = new OracleConnection(_configuration.GetConnectionString("OraDbCon"));
        //this.connection = new OracleConnection(_configuration["ConnectionStrings:OraDbCon"]);
        this.connection = new OracleConnection(_configuration.GetConnectionString("OraDbCon"));
    }

    public OracleCommand getCommand()
    {
        return new OracleCommand("", connection);
    }

    public void openConnection()
    {
        this.connection.Open();
    }

    public void closeConnection()
    {
        this.connection.Close();
    }

    public void killConnection()
    {
        if (this.connection.State == System.Data.ConnectionState.Open)
        {
            this.connection.Close();
        }
        connection = null!;
    }
}