using System;
using System.Linq;

namespace WindowsConfig
{
    public partial class DNS : System.Web.UI.Page
    {
        private string server;
        private string name;
        private string IP4;
        private string Sub;
        private string DNSIP;
        private string Gate;
        private string Syntax;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.DefaultButton = btnForward.UniqueID;
            server = Request.QueryString["Server"];
            name = Request.QueryString["SName"];
            IP4 = Request.QueryString["NWIP4"];
            Sub = Request.QueryString["NWSub"];
            Gate = Request.QueryString["NWGate"];
            DNSIP = Request.QueryString["NWDNS"];
            Syntax = Request.QueryString["Roles"];
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            Response.Redirect("Roles.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP);
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            string[] selected = Syntax.Split(';');

            if (selected.Contains("DHCP"))
            {
                Response.Redirect("Dhcp.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + txtName.Text + "&DNSZone=" + txtZone.Text + "&DNSArec=" + txtRec.Text + "&DNSIP=" + txtIP.Text);
            }
            else if (selected.Contains("DFS"))
            {
                Response.Redirect("Dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + txtName.Text + "&DNSZone=" + txtZone.Text + "&DNSArec=" + txtRec.Text + "&DNSIP=" + txtIP.Text);
            }
            else if (selected.Contains("AD"))
            {
                Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + txtName.Text + "&DNSZone=" + txtZone.Text + "&DNSArec=" + txtRec.Text + "&DNSIP=" + txtIP.Text);
            }
            else
            {
                //TODO Bring this to end page wit all the data cause 0 roles have to be installed and install the roles that were selected but dont need pages
            }
        }
    }
}