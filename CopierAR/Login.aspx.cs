using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CopierAR
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.Request.HttpMethod == "POST")
            {
                // Read parameters
                string CName = (Request.Form["CName"]);
                string CPwd = (Request.Form["CPwd"]);

                // Store data into MS SQL
                //--Insert/Update into table etc--
                bool exists = DBManager.CheckUserExists(CName);

                // Load dummy data
                string dummy = string.Format("{0}: {1}", CName, CPwd);

                // Return data to Unity
                Response.Clear();
                //Response.ContentType = "application/text; charset=utf-8";  
                Response.Write(exists);           
                Response.End();
            }
        }
    }
}