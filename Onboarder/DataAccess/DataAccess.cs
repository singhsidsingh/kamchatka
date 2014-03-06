﻿//The following were included by default on creation of this class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//The following is required for using DBProviderFactories amongst other things.
using System.Data.Common;

//The following is required for establishing connection with a MySql database.
//A reference to MySql.Data was added before writing the line below.
using MySql.Data.MySqlClient;
//Also, for the above reference, "Copy Local" was set to "True" in its properties.

//The following is required for establishing connection with an Oracle database.
//A reference to System.Data.OracleClient was added before writing the line below.
using System.Data.OracleClient;
//Also, for the above reference, "Copy Local" was set to "True" in its properties.

//The following is required for accessing the Web.config file of the application.
//Prior to writing the following line, a reference to System.Web and System.Configuration was added.
using System.Web.Configuration;

//The following is required for CommandTypes amongs many, many things.
using System.Data;

namespace DataAccess
{
    /// <summary>
    /// This class is the one that will communicate with the back end.
    /// All exchange of data to and from the back end will occur here.
    /// This class inherits the Constants class (Constants.cs) and
    /// implements the Interface class (Interface.cs).
    /// </summary>
    public class DataAccess: Constants, Interface
    {
        string connection_string = "";
        DbProviderFactory factory = null;
        DbConnection connection = null;
        DbCommand command = null;
        DbDataReader dataReader = null;

        /// <summary>
        /// Constructor which accepts a variable which tells it which
        /// connection string is to be picked up for establishing a 
        /// connection with the back end.
        /// </summary>
        /// <param name="backend_type">Backend Type (1 i.e. Oracle or 0 i.e. MySql)</param>
        public DataAccess(int backend_type)
        {
            if (backend_type == 0)
            {
                //Fetch the connection string for connecting with a MySql database.
                connection_string = WebConfigurationManager.ConnectionStrings["connection_string_mysql"].ConnectionString;
                //Initialize the required DbProviderFactory.
                factory = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
                sample_method();
            }
            else if (backend_type == 1)
            {
                //Fetch the connection string for connecting with an Oracle database.
                connection_string = WebConfigurationManager.ConnectionStrings["connection_string_oracle"].ConnectionString;
                //Initialize the required DbProviderFactory.
                factory = DbProviderFactories.GetFactory("System.Data.OracleClient");
                sample_method();
            }
        }

        /// <summary>
        /// Constructor overloading allows for those cases where a connection to the back end
        /// need not be established.
        /// </summary>
        public DataAccess()
        {
            connection_string = "";
        }

        public void sample_method(){
            try
            {
                connection = factory.CreateConnection();
                connection.ConnectionString = connection_string;
                connection.Open();
                using (command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM testtbl;";
                    using (dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            string x = dataReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string y = ex.Message;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                dataReader.Close();
                dataReader.Dispose();
                command.Dispose();
            }
        }

    }
}
