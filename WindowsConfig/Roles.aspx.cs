using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WindowsConfig
{
    public partial class Roles : System.Web.UI.Page
    {
        string server;
        string name;
        string IP4;
        string Sub;
        string DNS;
        string Gate;
        string syntax;
        int amount;


        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.DefaultButton = btnForward.UniqueID;
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            Response.Redirect("Network.aspx?Server=" + server + "&Name=" + name);
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            server = Request.QueryString["Server"];
            name = Request.QueryString["Name"];
            IP4 = Request.QueryString["IP4"];
            Sub = Request.QueryString["Sub"];
            Gate = Request.QueryString["Gate"];
            DNS = Request.QueryString["DNS"];

            foreach (ListItem item in cblLeft.Items)
            {
                if (item.Selected)
                {
                    syntax += item.Value;
                    amount++;
                }
            }
            foreach (ListItem item in cblRight.Items)
            {
                if (item.Selected)
                {
                    syntax += item.Value;
                    amount++;
                }
            }
            foreach (ListItem item in cblMiddle.Items)
            {
                if (item.Selected)
                {
                    syntax += item.Value;
                    amount++;
                }
            }
            if(amount > 0)
            {
                string[] selected = syntax.Split(';');

                foreach (string x in selected)
                {
                    if (x.Contains("DHCP"))
                    {
                        Response.Redirect("Dhcp.aspx?Server=" + server + "&Name=" + name + "&IP4=" + IP4 + "&Sub=" + Sub + "&Gate=" + Gate + "&DNS=" + DNS + "&Roles=" + syntax);
                        break;
                    }
                    else if (x.Contains("DNS"))
                    {
                        Response.Redirect("Dns.aspx?Server=" + server + "&Name=" + name + "&IP4=" + IP4 + "&Sub=" + Sub + "&Gate=" + Gate + "&DNS=" + DNS + "&Roles=" + syntax);
                        break;
                    }
                    else if (x.Contains("DFS"))
                    {
                        Response.Redirect("Dfs.aspx?Server=" + server + "&Name=" + name + "&IP4=" + IP4 + "&Sub=" + Sub + "&Gate=" + Gate + "&DNS=" + DNS + "&Roles=" + syntax);
                        break;
                    }
                    else if (x.Contains("AD"))
                    {
                        Response.Redirect("Ad.aspx?Server=" + server + "&Name=" + name + "&IP4=" + IP4 + "&Sub=" + Sub + "&Gate=" + Gate + "&DNS=" + DNS + "&Roles=" + syntax);
                        break;
                    }
                    else
                    {
                        //TODO Bring this to end page wit all the data cause 0 roles have to be installed and install the roles that were selected but dont need pages
                    }
                }
            }
            else
            {
                //TODO Bring this to end page wit all the data cause 0 roles have to be installed
            } 
        }
    }
}