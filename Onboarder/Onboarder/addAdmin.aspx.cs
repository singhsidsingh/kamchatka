using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Controller;

namespace Onboarder
{
    public partial class addAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                txt_datecreated_admin.Text = System.DateTime.Now.ToUniversalTime().ToString();
            }
            catch (Exception ex)
            {

            }
        }

        protected void Add_Admin(object sender, EventArgs e)
        {
            try
            {
                String empid_admin_frnt = "", email_admin_frnt = "", password_admin_frnt = "", firstname_admin_frnt = "", lastname_admin_frnt = "", account_admin_frnt = "", role_admin_frnt = "", project_admin_frnt = "";
                DateTime datecreated_admin_frnt;

                empid_admin_frnt = txt_empid_admin.Text;
                email_admin_frnt = txt_email_admin.Text;
                password_admin_frnt = txt_password_admin.Text;
                firstname_admin_frnt = txt_firstname_admin.Text;
                lastname_admin_frnt = txt_lastname_admin.Text;
                account_admin_frnt = drpdwn_account_admin.SelectedItem.Value.ToString();
                datecreated_admin_frnt = DateTime.Parse(txt_datecreated_admin.Text);
                role_admin_frnt = drpdwn_role_admin.SelectedItem.Value.ToString();
                project_admin_frnt = drpdwn_project_admin.SelectedItem.Value.ToString();

                Controller.Controller obj = new Controller.Controller();

                int result = 0;
                result = obj.Add_Admin(empid_admin_frnt, email_admin_frnt, password_admin_frnt, firstname_admin_frnt, lastname_admin_frnt, account_admin_frnt, datecreated_admin_frnt, role_admin_frnt, project_admin_frnt);
            }
            catch (Exception ex)
            {

            }
        }
    }
}