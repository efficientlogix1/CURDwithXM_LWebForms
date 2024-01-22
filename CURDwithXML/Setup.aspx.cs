using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CURDwithXML
{
    public partial class Setup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                string recordId = Request.QueryString["recordId"];
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/App_Data/Sample.xml"));
                DataTable altPhones = ds.Tables["Alt" + recordId + "Phones"];
                DataTable altCode = ds.Tables["Alt" + recordId + "Code"];
                DataTable altHunt = ds.Tables["Alt" + recordId + "Hunt"];
                SNo.Text = recordId;
                AltPhones_Tam1.Text = altPhones.Rows[0]["Tam1"].ToString();
                AltPhones_Tam2.Text = altPhones.Rows[0]["Tam2"].ToString();
                AltPhones_Tam1VM.Text = altPhones.Rows[0]["Tam1VM"].ToString();
                AltPhones_Tam2VM.Text = altPhones.Rows[0]["Tam2VM"].ToString();
                AltCode_Tam1.Text = altCode.Rows[0]["Tam1"].ToString();
                AltCode_Tam2.Text = altCode.Rows[0]["Tam2"].ToString();
                AltHunt_G1.Text = altHunt.Rows[0]["G1"].ToString();
                AltHunt_G2.Text = altHunt.Rows[0]["G2"].ToString();
            }
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (AltPhones_Tam1.Text.Trim() == String.Empty||
            AltPhones_Tam2.Text.Trim() == String.Empty ||
            AltPhones_Tam1VM.Text.Trim() == String.Empty ||
            AltPhones_Tam2VM.Text.Trim() == String.Empty ||
            AltCode_Tam1.Text.Trim() == String.Empty ||
            AltCode_Tam2.Text.Trim() == String.Empty ||
            AltHunt_G1.Text.Trim() == String.Empty ||
            AltHunt_G2.Text.Trim() == String.Empty)
            {
                errMsg.Text = "Please fill all fields";
            }
            else
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
                int sNo = 1;
                foreach (var item in lstData)
                {
                    DataRow dr = dataTable.NewRow();
                    if (sNo==Convert.ToInt32(SNo.Text))
                    {
                        dr["SNo"] = sNo;
                        dr["AltPhones_Tam1"] = AltPhones_Tam1.Text;
                        dr["AltPhones_Tam2"] = AltPhones_Tam2.Text;
                        dr["AltPhones_Tam1VM"] = AltPhones_Tam1VM.Text;
                        dr["AltPhones_Tam2VM"] = AltPhones_Tam2VM.Text;
                        dr["AltCode_Tam1"] = AltCode_Tam1.Text;
                        dr["AltCode_Tam2"] = AltCode_Tam2.Text;
                        dr["AltHunt_G1"] = AltHunt_G1.Text;
                        dr["AltHunt_G2"] = AltHunt_G2.Text;
                    }
                    else
                    {
                        dr["SNo"] = sNo;
                        dr["AltPhones_Tam1"] = item.altPhones.Tam1;
                        dr["AltPhones_Tam2"] = item.altPhones.Tam2;
                        dr["AltPhones_Tam1VM"] = item.altPhones.Tam1VM;
                        dr["AltPhones_Tam2VM"] = item.altPhones.Tam2VM;
                        dr["AltCode_Tam1"] = item.altCode.Tam1;
                        dr["AltCode_Tam2"] = item.altCode.Tam2;
                        dr["AltHunt_G1"] = item.altHunt.G1;
                        dr["AltHunt_G2"] = item.altHunt.G2;
                    }
                    
                    dataTable.Rows.Add(dr);
                    sNo++;
                }
                string text ="<Alternates>\n";
                foreach (DataRow row in dataTable.Rows)
                {
                    text = text + "<Alt" + row["SNo"] + "Phones>\n"
                    + "<Tam1>" + row["AltPhones_Tam1"] + "</Tam1>\n"
                    + "<Tam2>" + row["AltPhones_Tam2"] + "</Tam2>\n"
                    + "<Tam1VM>" + row["AltPhones_Tam1VM"] + "</Tam1VM>\n"
                    + "<Tam2VM>" + row["AltPhones_Tam2VM"] + "</Tam2VM>\n"
                    + "</Alt" + row["SNo"] + "Phones>\n";

                    text = text + "<Alt" + row["SNo"] + "Code>\n"
                    + "<Tam1>" + row["AltCode_Tam1"] + "</Tam1>\n"
                    + "<Tam2>" + row["AltCode_Tam2"] + "</Tam2>\n"
                    + "</Alt" + row["SNo"] + "Code>\n";

                    text = text + "<Alt" + row["SNo"] + "Hunt>\n"
                    + "<G1>" + row["AltHunt_G1"] + "</G1>\n"
                    + "<G2>" + row["AltHunt_G2"] + "</G2>\n"
                    + "</Alt" + row["SNo"] + "Hunt>\n";
                }
                text = text + "</Alternates>";
                File.WriteAllText(Server.MapPath("~/App_Data/Sample.xml"), text);
                Response.Redirect("Default.aspx");
            }
        }
    }
}