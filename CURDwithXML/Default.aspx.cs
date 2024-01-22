using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CURDwithXML
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/App_Data/Sample.xml"));
            List<XMLData> lstData = new List<XMLData>();
            XMLData data = new XMLData();
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                DataTable dt = ds.Tables[i];
                var tab = (i + 1) % 3;
                if (tab == 1)
                {
                    data = new XMLData();
                    data.altPhones = new AltPhones();
                    data.altPhones.Tam1 = dt.Rows[0]["Tam1"].ToString();
                    data.altPhones.Tam2 = dt.Rows[0]["Tam2"].ToString();
                    data.altPhones.Tam1VM = dt.Rows[0]["Tam1VM"].ToString();
                    data.altPhones.Tam2VM = dt.Rows[0]["Tam2VM"].ToString();
                }
                if (tab == 2)
                {
                    data.altCode = new AltCode();
                    data.altCode.Tam1 = dt.Rows[0]["Tam1"].ToString();
                    data.altCode.Tam2 = dt.Rows[0]["Tam2"].ToString();
                }
                if (tab == 0)
                {
                    data.altHunt = new AltHunt();
                    data.altHunt.G1 = dt.Rows[0]["G1"].ToString();
                    data.altHunt.G2 = dt.Rows[0]["G2"].ToString();
                    lstData.Add(data);
                }
            }
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("SNo", typeof(int));
            dataTable.Columns.Add("AltPhones_Tam1", typeof(string));
            dataTable.Columns.Add("AltPhones_Tam2", typeof(string));
            dataTable.Columns.Add("AltPhones_Tam1VM", typeof(string));
            dataTable.Columns.Add("AltPhones_Tam2VM", typeof(string));
            dataTable.Columns.Add("AltCode_Tam1", typeof(string));
            dataTable.Columns.Add("AltCode_Tam2", typeof(string));
            dataTable.Columns.Add("AltHunt_G1", typeof(string));
            dataTable.Columns.Add("AltHunt_G2", typeof(string));
            int SNo = 1;
            foreach (var item in lstData)
            {
                DataRow dr = dataTable.NewRow();
                dr["SNo"] = SNo;
                dr["AltPhones_Tam1"] = item.altPhones.Tam1;
                dr["AltPhones_Tam2"] = item.altPhones.Tam2;
                dr["AltPhones_Tam1VM"] = item.altPhones.Tam1VM;
                dr["AltPhones_Tam2VM"] = item.altPhones.Tam2VM;
                dr["AltCode_Tam1"] = item.altCode.Tam1;
                dr["AltCode_Tam2"] = item.altCode.Tam2;
                dr["AltHunt_G1"] = item.altHunt.G1;
                dr["AltHunt_G2"] = item.altHunt.G2;
                dataTable.Rows.Add(dr);
                SNo++;
            }
            GridViewResult.DataSource = dataTable;
            GridViewResult.DataBind();
        }
        protected void GridViewResult_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditRow")
            {
                string rowNo = e.CommandArgument.ToString();
                Response.Redirect("Setup.aspx?recordId=" + rowNo);
            }
        }
    }
    public class XMLData
    {
        public AltPhones altPhones { get; set; }
        public AltCode altCode { get; set; }
        public AltHunt altHunt { get; set; }
    }
    public class AltPhones
    {
        public string Tam1 { get; set; }
        public string Tam2 { get; set; }
        public string Tam1VM { get; set; }
        public string Tam2VM { get; set; }
    }
    public class AltCode
    {
        public string Tam1 { get; set; }
        public string Tam2 { get; set; }
    }
    public class AltHunt
    {
        public string G1 { get; set; }
        public string G2 { get; set; }
    }
}