using Newtonsoft.Json;

namespace EFDCS.Models
{
    /// <summary>
    /// Stores connection string parameters.
    /// </summary>
    /// Additional parameters can be added.
    public class ConnectionString
    {
        public string Server { get; set; }

        public string Port { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public string Database { get; set; }

        [JsonIgnore]
        public string FormedConnectionString => $"server = {Server}; port={Port}; user={User}; password={Password}; database={Database}"; //Returns the generated connection string
    }
}
