//The following were included by default on creation of this class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//The controller class needs to communicate with the DataAccess class.
using DataAccess;

namespace Controller
{
    /// <summary>
    /// The controller class acts as the point of contact
    /// between the DataAccess class and the code behind code.
    /// 
    /// Note: The back end type (see below) is set in this class.
    /// </summary>
    public class Controller
    {
        int backend_type = 999; // Let it be initialized with 999. The more striking the better.

        DataAccess.DataAccess obj = null;
        
        /// <summary>
        /// In the Controller's constructor, the backend type is being set.
        /// This has massive ramifications in the DataAccess class.
        /// </summary>
        public Controller()
        {
            //Change the value of the following variable as per your requirements:
            backend_type = 0; // 0 is for when the database is MySql and 1 is for when Oracle is being used.

            //Creating an object of the DataAccess class and passing the back end type as a parameter.
            obj = new DataAccess.DataAccess(backend_type);
        }

        /// <summary>
        /// Function to add a new administrator.
        /// </summary>
        /// <param name="empid_admin_c">Employee Id.</param>
        /// <param name="email_admin_c">E-mail Address</param>
        /// <param name="password_admin_c">Password</param>
        /// <param name="firstname_admin_c">First Name</param>
        /// <param name="lastname_admin_c">Last Name</param>
        /// <param name="account_admin_c">Account</param>
        /// <param name="datecreated_admin_c">Account Creation Date</param>
        /// <param name="role_admin_c">Role</param>
        /// <param name="project_admin_c">Project</param>
        public int Add_Admin(string empid_admin_c, string email_admin_c, string password_admin_c, string firstname_admin_c, string lastname_admin_c, string account_admin_c, DateTime datecreated_admin_c, string role_admin_c, string project_admin_c)
        {
            try
            {
                int result = 0;
                result = obj.Add_Admin(empid_admin_c, email_admin_c, password_admin_c, firstname_admin_c, lastname_admin_c, account_admin_c, datecreated_admin_c, role_admin_c, project_admin_c);
                return result;
            }
            catch (Exception ex)
            {
                //Simply throw the exception; it will be handled in the code behind.
                throw ex;
            }
            finally
            {
            }
        }
    }
}
