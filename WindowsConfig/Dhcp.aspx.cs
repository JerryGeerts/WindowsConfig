using System;
using System.Web.UI;

namespace WindowsConfig
{
    public partial class Dhcp : System.Web.UI.Page
    {
        private string server;
        private string name;
        private string IP4;
        private string Sub;
        private string DNSIP;
        private string Gate;
        private string Syntax;
        private string DNSName;
        private string ZoneFile;
        private string ARecord;
        private string DNSServerIP;

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
            DNSName = Request.QueryString["DNSName"];
            ZoneFile = Request.QueryString["DNSZone"];
            ARecord = Request.QueryString["DNSArec"];
            DNSServerIP = Request.QueryString["DNSIP"];
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            DNSName = Request.QueryString["DNSName"];
            if (DNSName == null)
            {
                Response.Redirect("Roles.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP);
            }
            else
            {
                Response.Redirect("Dns.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax);
            }
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (txtScope.Text != "")
            {
                if (txtStart.Text != "" && revStart.IsValid)
                {
                    if (txtEnd.Text != "" && revEnd.IsValid)
                    {
                        if (txtSubnet.Text != "" && revSubnet.IsValid)
                        {
                            if (DNSName == null)
                            {
                                Response.Redirect("DhcpOptional.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + txtScope.Text + "&DHCPStart=" + txtStart.Text + "&DHCPEnd=" + txtEnd.Text + "&DHCPSub" + txtSubnet.Text);
                            }
                            else
                            {
                                Response.Redirect("DhcpOptional.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DHCPName=" + txtScope.Text + "&DHCPStart=" + txtStart.Text + "&DHCPEnd=" + txtEnd.Text + "&DHCPSub=" + txtSubnet.Text);
                            }
                        }
                        else
                        {
                            lblError.Text = "Please enter a valid Subnet address";
                        }
                    }
                    else
                    {
                        lblError.Text = "Please enter a valid end IP address";
                    }
                }
                else
                {
                    lblError.Text = "Please enter a valid start IP address";
                }
            }
            else
            {
                lblError.Text = "Please enter a valid Scope name";
            }
        }
    }
}