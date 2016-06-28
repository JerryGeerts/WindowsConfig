using System;
using System.Linq;

namespace WindowsConfig
{
    public partial class DFS : System.Web.UI.Page
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
        private string DHCPName;
        private string DHCPStart;
        private string DHCPEnd;
        private string DHCPSub;
        private string DHCPRouter;
        private string DHCPDNSName;
        private string DHCPDNSIP;
        private string[] selected;

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
            DHCPName = Request.QueryString["DHCPName"];
            DHCPStart = Request.QueryString["DHCPStart"];
            DHCPEnd = Request.QueryString["DHCPEnd"];
            DHCPSub = Request.QueryString["DHCPSub"];
            DHCPRouter = Request.QueryString["DHCPRouter"];
            DHCPDNSName = Request.QueryString["DHCPDNSName"];
            DHCPDNSIP = Request.QueryString["DHCPDNSIP"];
            try
            {
                selected = Syntax.Split(';');
            }
            catch
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            if (DHCPName == null)
            {
                if (DNSName == null)
                {
                    Response.Redirect("Roles.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP);
                }
                else
                {
                    Response.Redirect("Dns.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax);
                }
            }
            else
            {
                if (DNSName == null)
                {
                    Response.Redirect("DhcpOptional.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub=" + DHCPSub);
                }
                else
                {
                    Response.Redirect("DhcpOptional.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub=" + DHCPSub);
                }
            }
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            if (txtNameSpace.Text != "")
            {
                if (txtServer.Text != "")
                {
                    if (selected.Contains("AD"))
                    {
                        if (DNSName == null)
                        {
                            if (DHCPName == null)
                            {
                                Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DFSName=" + txtNameSpace.Text + "&DFSServer" + txtServer.Text);
                            }
                            else
                            {
                                if (DHCPDNSName == null)
                                {
                                    Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub=" + DHCPSub + "&DFSName=" + txtNameSpace.Text + "&DFSServer=" + txtServer.Text);
                                }
                                else
                                {
                                    Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub=" + DHCPSub + "&DHCPRouter=" + DHCPRouter + "&DHCPName=" + DHCPName + "&DHCPDNSIP=" + DHCPDNSIP + "&DFSName=" + txtNameSpace.Text + "&DFSServer=" + txtServer.Text);
                                }
                            }
                        }
                        else
                        {
                            if (DHCPName == null)
                            {
                                Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DFSName=" + txtNameSpace.Text + "&DFSServer=" + txtServer.Text);
                            }
                            else
                            {
                                Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub=" + DHCPSub + "&DHCPRouter=" + DHCPRouter + "&DHCPName=" + DHCPName + "&DHCPDNSIP=" + DHCPDNSIP + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DFSName=" + txtNameSpace.Text + "&DFSServer=" + txtServer.Text);
                            }
                        }
                    }
                    else
                    {
                        //TODO Ending
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
    }
}