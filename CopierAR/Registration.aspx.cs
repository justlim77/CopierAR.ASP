using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CopierAR
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.Request.HttpMethod == "POST")
            {
                // Read parameters
                string CName = (Request.Form["CName"]);
                string Company = (Request.Form["Company"]);
                string CPwd = (Request.Form["CPwd"]);
                string Email = (Request.Form["Email"]);

                RegistrationData rd = new RegistrationData(CName, Company, CPwd, Email);
                
                // Store data into MS SQL
                //--Insert/Update into table etc--
                bool userCreated = DBManager.CreateUser(rd);

                // Return data to Unity
                Response.Clear();
                //Response.ContentType = "application/text; charset=utf-8";  
                Response.Write(userCreated);
                Response.End();
            }
        }
    }
}