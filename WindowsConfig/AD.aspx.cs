using System;

namespace WindowsConfig
{
    public partial class AD : System.Web.UI.Page
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
        private string DFSServer;
        private string DFSName;

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

            DFSServer = Request.QueryString["DFSServer"];
            DFSName = Request.QueryString["DFSName"];
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            if (DFSName == null)
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
                        Response.Redirect("DhcpOptional.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub);
                    }
                    else
                    {
                        Response.Redirect("DhcpOptional.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub);
                    }
                }
            }
            else
            {
                if (DHCPDNSName == null)
                {
                    if (DHCPName == null)
                    {
                        if (DNSName == null)
                        {
                            Response.Redirect("Dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax);
                        }
                        else
                        {
                            Response.Redirect("Dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP);
                        }
                    }
                    else
                    {
                        if (DNSName == null)
                        {
                            Response.Redirect("Dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub);
                        }
                        else
                        {
                            Response.Redirect("Dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub);
                        }
                    }
                }
                else
                {
                    if (DHCPName == null)
                    {
                        if (DNSName == null)
                        {
                            Response.Redirect("Dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPRouter=" + DHCPRouter + "&DHCPName=" + DHCPName + "&DHCPDNSIP=" + DHCPDNSIP);
                        }
                        else
                        {
                            Response.Redirect("Dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DHCPRouter=" + DHCPRouter + "&DHCPName=" + DHCPName + "&DHCPDNSIP=" + DHCPDNSIP);
                        }
                    }
                    else
                    {
                        if (DNSName == null)
                        {
                            Response.Redirect("Dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub + "&DHCPRouter=" + DHCPRouter + "&DHCPDNSIP=" + DHCPDNSIP);
                        }
                        else
                        {
                            Response.Redirect("Dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub + "&DHCPRouter=" + DHCPRouter + "&DHCPDNSIP=" + DHCPDNSIP);
                        }
                    }
                }
            }
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            if (txtDomain.Text != "")
            {
                if (txtPass.Text != "" && txtPass.Text == txtConfirm.Text)
                {
                    if (txtPass.Text.Length > 5)
                    {
                        string URL = Request.Url.AbsoluteUri.Replace("AD.aspx?", "Result.aspx?Domain=" + txtDomain.Text + "&Pass=" + txtPass.Text + "&");
                        Response.Redirect(URL);
                    }
                    else
                    {
                        lblError.Text = "Please take a password longer then 5 char";
                    }
                }
                else
                {
                    lblError.Text = "The passwords you enter don't match";
                }
            }
        }
    }
}