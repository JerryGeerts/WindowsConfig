using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace WindowsConfig
{
    public partial class Roles : System.Web.UI.Page
    {
        private string server;
        private string name;
        private string IP4;
        private string Sub;
        private string DNSIP;
        private string Gate;
        private string Syntax;
        private int amount;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.DefaultButton = btnForward.UniqueID;
            server = Request.QueryString["Server"];
            name = Request.QueryString["SName"];
            IP4 = Request.QueryString["NWIP4"];
            Sub = Request.QueryString["NWSub"];
            Gate = Request.QueryString["NWGate"];
            DNSIP = Request.QueryString["NWDNS"];
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            Response.Redirect("Network.aspx?Server=" + server + "&SName=" + name);
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in cblLeft.Items)
            {
                if (item.Selected)
                {
                    Syntax += item.Value;
                    amount++;
                }
            }
            foreach (ListItem item in cblRight.Items)
            {
                if (item.Selected)
                {
                    Syntax += item.Value;
                    amount++;
                }
            }
            foreach (ListItem item in cblMiddle.Items)
            {
                if (item.Selected)
                {
                    Syntax += item.Value;
                    amount++;
                }
            }

            if (amount > 0)
            {
                string[] selected = Syntax.Split(';');

                if (selected.Contains("DNS"))
                {
                    Response.Redirect("Dns.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax);
                }
                else if (selected.Contains("DHCP"))
                {
                    Response.Redirect("Dhcp.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax);
                }
                else if (selected.Contains("DFS"))
                {
                    Response.Redirect("Dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax);
                }
                else if (selected.Contains("AD"))
                {
                    Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax);
                }
                else
                {
                    Response.Redirect("Result.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax);
                }
            }
            else
            {
                Response.Redirect("Result.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax);
            }
        }
    }
}