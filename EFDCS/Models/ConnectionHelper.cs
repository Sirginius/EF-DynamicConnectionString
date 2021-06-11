using Newtonsoft.Json;
using System;
using System.IO;

namespace EFDCS.Models
{
    /// <summary>
    /// Helps get data from file.
    /// </summary>
    public class ConnectionHelper
    {
        private string _path = $"{AppDomain.CurrentDomain.BaseDirectory}config.json"; //Specifies the path to the file
        public string Path => _path; //Returns the path to the file
        private string _input { get; set; }

        /// <summary>
        /// Reads a file from a base directory.
        /// </summary>
        public ConnectionHelper()
        {
            using (StreamReader sr = new StreamReader(_path))
            {
                _input = sr.ReadToEnd();
            }
        }

        /// <summary>
        /// Reads a file from a given directory.
        /// </summary>
        public ConnectionHelper(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                _input = sr.ReadToEnd();
            }
        }

        /// <summary>
        /// Returns ConnectionString object.
        /// </summary>
        public ConnectionString GetConnectionString() => JsonConvert.DeserializeObject<ConnectionString>(_input);

        /// <summary>
        /// Creates a file with configurable parameters in the base directory.
        /// </summary>
        /// Additional parameters can be added.
        public void CreateFile(string server, string port, string user, string password, string database)
        {
            ConnectionString connectionString = new ConnectionString() { Server = server, Port = port, User = user, Password = password, Database = database };
            string output = JsonConvert.SerializeObject(connectionString);

            using (StreamWriter sw = new StreamWriter(_path))
            {
                sw.WriteLine("//Connection string parameters:");
                sw.Write(output);
            }
        }

        /// <summary>
        /// Creates a file with configurable parameters in the specified directory.
        /// </summary>
        /// Additional parameters can be added.
        public void CreateFile(string server, string port, string user, string password, string database, string path)
        {
            ConnectionString connectionString = new ConnectionString() { Server = server, Port = port, User = user, Password = password, Database = database };
            string output = JsonConvert.SerializeObject(connectionString);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("//Connection string parameters:");
                sw.Write(output);
            }
        }
    }
}
