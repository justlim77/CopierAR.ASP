using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace CopierAR
{
    public partial class ValidateCreds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.Request.HttpMethod == "POST")
            {
                string CName = (Request.Form["CName"]);

                RegistrationData rd = DBManager.GetRegistrationData(CName);
                string jsonResult = JsonConvert.SerializeObject(rd);

                Response.Clear();
                Response.ContentType = "application/json;";
                Response.Write(jsonResult);
                Response.End();
            }
        }
    }
}