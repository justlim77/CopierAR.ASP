using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace CopierAR
{
    public partial class SalesInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.Request.HttpMethod == "POST")
            {
                // Read parameters
                //string json = (Request.Form["json"]);

                //string json;
                //using (var reader = new StreamReader(Request.InputStream))
                //{
                //    json = reader.ReadToEnd();
                //}

                //SalesInfoData data = JsonConvert.DeserializeObject<SalesInfoData>(json);

                string SName = Request.Form["SName"];
                decimal PostalCod = Convert.ToDecimal(Request.Form["PostalCod"]);
                DateTime? LoginTime = Convert.ToDateTime(Request.Form["LoginTime"]);
                string PhotoCopierModel = Request.Form["PhotoCopierModel"];
                string DemoDuration = Request.Form["DemoDuration"];
                string Frequency = Request.Form["Frequency"];

                SalesInfoData data = new SalesInfoData();
                data.SName = SName;
                data.PostalCod = PostalCod;
                data.LoginTime = LoginTime;
                data.PhotoCopierModel = PhotoCopierModel;
                data.DemoDuration = DemoDuration;
                data.Frequency = Frequency;

                // Insert new sales info row with data provided
                bool result = DBManager.InsertSalesInfo(data);

                // Return result
                Response.Clear();
                Response.Write(result);
                Response.End();
            }
        }
    }
}