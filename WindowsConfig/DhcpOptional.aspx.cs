using System;
using System.Linq;
using System.Web.UI;

namespace WindowsConfig
{
    public partial class DhcpOptional : System.Web.UI.Page
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
            selected = Syntax.Split(';');
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dhcp.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax);
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (txtRouter.Text != "")
            {
                if (txtName.Text != "")
                {
                    if (txtDNSIP.Text != "" && revDNSIP.IsValid)
                    {
                        if (selected.Contains("DFS"))
                        {
                            if (DNSName == null)
                            {
                                Response.Redirect("dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub + "&DHCPRouter=" + txtRouter.Text + "&DHCPName=" + txtName.Text + "&DHCPDNSIP=" + txtDNSIP.Text);
                            }
                            else
                            {
                                Response.Redirect("dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub + "&DHCPRouter=" + txtRouter.Text + "&DHCPDNSName=" + txtName.Text + "&DHCPDNSIP=" + txtDNSIP.Text);
                            }
                        }
                        else if (selected.Contains("AD"))
                        {
                            if (DNSName == null)
                            {
                                Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub + "&DHCPRouter=" + txtRouter.Text + "&DHCPName=" + txtName.Text + "&DHCPDNSIP=" + txtDNSIP.Text);
                            }
                            else
                            {
                                Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub + "&DHCPRouter=" + txtRouter.Text + "&DHCPDNSName=" + txtName.Text + "&DHCPDNSIP=" + txtDNSIP.Text);
                            }
                        }
                        else
                        {
                            //TODO Ending
                        }
                    }
                    else
                    {
                        lblError.Text = "Please enter a valid DNS IP address";
                    }
                }
                else
                {
                    lblError.Text = "Please enter a correct DNS name";
                }
            }
            else
            {
                if (selected.Contains("DFS"))
                {
                    if (DNSName == null)
                    {
                        Response.Redirect("dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub + "&DHCPRouter=" + txtRouter.Text + "&DHCPName=" + txtName.Text + "&DHCPDNSIP=" + txtDNSIP.Text);
                    }
                    else
                    {
                        Response.Redirect("dfs.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub + "&DHCPRouter=" + txtRouter.Text + "&DHCPDNSName=" + txtName.Text + "&DHCPDNSIP=" + txtDNSIP.Text);
                    }
                }
                else if (selected.Contains("AD"))
                {
                    if (DNSName == null)
                    {
                        Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub" + DHCPSub + "&DHCPRouter=" + txtRouter.Text + "&DHCPName=" + txtName.Text + "&DHCPDNSIP=" + txtDNSIP.Text);
                    }
                    else
                    {
                        Response.Redirect("AD.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + IP4 + "&NWSub=" + Sub + "&NWGate=" + Gate + "&NWDNS=" + DNSIP + "&Roles=" + Syntax + "&DNSName=" + DNSName + "&DNSZone=" + ZoneFile + "&DNSArec=" + ARecord + "&DNSIP=" + DNSServerIP + "&DHCPName=" + DHCPName + "&DHCPStart=" + DHCPStart + "&DHCPEnd=" + DHCPEnd + "&DHCPSub=" + DHCPSub + "&DHCPRouter=" + txtRouter.Text + "&DHCPDNSName=" + txtName.Text + "&DHCPDNSIP=" + txtDNSIP.Text);
                    }
                }
                else
                {
                    //TODO Ending
                }
            }
        }
    }
}