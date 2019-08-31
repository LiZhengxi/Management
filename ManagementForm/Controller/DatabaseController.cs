using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementForm.Controller
{
    class DatabaseController
    {
        public async Task<int> databaseTestAsync()
        {
            int retour = 0;
            string connectionName = "";
            string connectionString = "";

            // Get the application configuration file.
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

            // Get the conectionStrings section.
            ConnectionStringsSection csSection = config.ConnectionStrings;
            for (int i = 0; i < ConfigurationManager.ConnectionStrings.Count; i++)
            {
                ConnectionStringSettings cs = csSection.ConnectionStrings[i];
                connectionName = cs.Name;
                if (connectionName == "ManagementDbContext")
                {
                    connectionString = cs.ConnectionString;
                    //Console.WriteLine(connectionString);
                    break;
                }
            }
            if (connectionString != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        await connection.OpenAsync();
                        retour = 1;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        retour = 0;
                    }
                }
            }
            Comon.DatabaseStaus = retour;
            return retour;
        }
    }
}
