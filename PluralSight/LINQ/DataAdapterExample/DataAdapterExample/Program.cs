using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace DataAdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = GetConnectionString();
            ConnectToData(connectionString);
        }

        private static void ConnectToData(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "version");
                adapter.TableMappings.Add("View", "vPersonAppBrandOffer");

                connection.Open();
                Console.WriteLine("SqlConnection is open");

                SqlCommand command = new SqlCommand(
                    "SELECT Major, Minor FROM version;" +

                    "SELECT ApplicationID, Surname, Brand FROM vPersonAppBrandOffer"
                    , connection
                    );

                command.CommandType = CommandType.Text;

                adapter.SelectCommand = command;

                DataSet dataset = new DataSet("Version");
                adapter.Fill(dataset);

                DataSet apps = new DataSet("vPersonAppBrandOffer");
                adapter.Fill(apps);

                connection.Close();
                Console.WriteLine("SqlConnection is closed");

                //DataTable version = dataset.Tables["Version"];
                var version = dataset.Tables["Version"].AsEnumerable();

                //var query =
                //    //from ver in version.AsEnumerable()
                //    from ver in version
                //    select ver;

                var query = version.Select(ver => ver);

                foreach (var row in query)
                {
                    Console.WriteLine("Major: {0} Minor: {1}", row["Major"], row["Minor"]);
                }

                var myApps = apps.Tables["vPersonAppBrandOffer"].AsEnumerable();
                var query2 = myApps.Select(app => app);

                foreach (var row in query2)
                {
                    Console.WriteLine("AppId: {0} Surname: {1} Brand: {2}", row["ApplicationID"], row["Surname"], row["Brand"]);
                }



            }
        }

        private static string GetConnectionString()
        {
            return @"Data Source=DAPTAC01\SQL;Initial Catalog=DTS;"
                + "Integrated Security=SSPI";
        }
    }
}
