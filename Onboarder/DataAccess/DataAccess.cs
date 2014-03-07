//The following were included by default on creation of this class.
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
            }
            else if (backend_type == 1)
            {
                //Fetch the connection string for connecting with an Oracle database.
                connection_string = WebConfigurationManager.ConnectionStrings["connection_string_oracle"].ConnectionString;
                //Initialize the required DbProviderFactory.
                factory = DbProviderFactories.GetFactory("System.Data.OracleClient");
            }

            //Initialize the connection object with the relevant connection string.
            connection = factory.CreateConnection();
            connection.ConnectionString = connection_string;
        }

        /// <summary>
        /// Constructor overloading allows for those cases where a connection to the back end
        /// need not be established.
        /// </summary>
        public DataAccess()
        {
            connection_string = "";
        }

        public int Add_Admin(string empid_admin_da, string email_admin_da, string password_admin_da, string firstname_admin_da, string lastname_admin_da, string account_admin_da, DateTime datecreated_admin_da, string role_admin_da, string project_admin_da)
        {
            try
            {
                int no_of_records_updated = 0;

                //Create and configure command object for executing your SQL (text or stored procedure).
                DbCommand command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                //Defining the name of our stored procedure.
                command.CommandText = CONST_ADD_ADMIN_PROC;

                //Defining the parameters for our procedure.
                DbParameter param_0 = factory.CreateParameter();
                param_0.ParameterName = "@p_in_empid_admin";
                param_0.DbType = DbType.String;
                param_0.Size = 7;
                param_0.Direction = ParameterDirection.Input;
                param_0.Value = empid_admin_da;
                command.Parameters.Add(param_0);

                DbParameter param_1 = factory.CreateParameter();
                param_1.ParameterName = "@p_in_email_admin";
                param_1.DbType = DbType.String;
                param_1.Size = 60;
                param_1.Direction = ParameterDirection.Input;
                param_1.Value = email_admin_da;
                command.Parameters.Add(param_1);

                DbParameter param_2 = factory.CreateParameter();
                param_2.ParameterName = "@p_in_password_admin";
                param_2.DbType = DbType.String;
                param_2.Size = 60;
                param_2.Direction = ParameterDirection.Input;
                param_2.Value = password_admin_da;
                command.Parameters.Add(param_2);

                DbParameter param_3 = factory.CreateParameter();
                param_3.ParameterName = "@p_in_firstname_admin";
                param_3.DbType = DbType.String;
                param_3.Size = 50;
                param_3.Direction = ParameterDirection.Input;
                param_3.Value = firstname_admin_da;
                command.Parameters.Add(param_3);

                DbParameter param_4 = factory.CreateParameter();
                param_4.ParameterName = "@p_in_lastname_admin";
                param_4.DbType = DbType.String;
                param_4.Size = 50;
                param_4.Direction = ParameterDirection.Input;
                param_4.Value = lastname_admin_da;
                command.Parameters.Add(param_4);

                DbParameter param_5 = factory.CreateParameter();
                param_5.ParameterName = "@p_in_account_admin";
                param_5.DbType = DbType.String;
                param_5.Size = 70;
                param_5.Direction = ParameterDirection.Input;
                param_5.Value = account_admin_da;
                command.Parameters.Add(param_5);

                DbParameter param_6 = factory.CreateParameter();
                param_6.ParameterName = "@p_in_datecreated_admin";
                param_6.DbType = DbType.DateTime;
                param_6.Direction = ParameterDirection.Input;
                param_6.Value = datecreated_admin_da;
                command.Parameters.Add(param_6);

                DbParameter param_7 = factory.CreateParameter();
                param_7.ParameterName = "@p_in_role_admin";
                param_7.DbType = DbType.String;
                param_7.Size = 30;
                param_7.Direction = ParameterDirection.Input;
                param_7.Value = role_admin_da;
                command.Parameters.Add(param_7);

                DbParameter param_8 = factory.CreateParameter();
                param_8.ParameterName = "@p_in_project_admin";
                param_8.DbType = DbType.String;
                param_8.Size = 100;
                param_8.Direction = ParameterDirection.Input;
                param_8.Value = project_admin_da;
                command.Parameters.Add(param_8);

                //Open the connection.
                connection.Open();

                no_of_records_updated = command.ExecuteNonQuery();

                command.Parameters.Clear();

                return no_of_records_updated;


            }
            catch (Exception ex)
            {
                //Simply throw the exception; it will be handled in the code behind.
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open || connection != null)
                {
                    //Release resources no longer needed and close and dispose the connection.
                    

                    connection.Close();
                    connection.Dispose();
                }
            }
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
