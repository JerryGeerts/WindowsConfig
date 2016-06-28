using System;
using System.Linq;

namespace WindowsConfig
{
    public partial class Result : System.Web.UI.Page
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
        private string Domain;
        private string Pass;
        private string[] selected;

        protected void Page_Load(object sender, EventArgs e)
        {
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

            Domain = Request.QueryString["Domain"];
            Pass = Request.QueryString["Pass"];

            try
            {
                selected = Syntax.Split(';');
            }
            catch
            {
                Response.Redirect("index.aspx");
            }

            txtBox.Text += "Rename-Computer " + name;
            txtBox.Text += Environment.NewLine;
            txtBox.Text += Environment.NewLine;
            txtBox.Text += "netsh interface ip set address \"Ethernet0\" static " + IP4 + " " + Sub + " " + Gate;
            txtBox.Text += Environment.NewLine;
            txtBox.Text += "Set-DNSClientServerAddress -ServerAddresses " + DNSIP + " \"Ethernet0\"";
            txtBox.Text += Environment.NewLine;
            txtBox.Text += Environment.NewLine;
            txtBox.Text += "Restart-Computer";
            txtBox.Text += Environment.NewLine;
            txtBox.Text += Environment.NewLine;

            if (selected.Contains("DNS"))
            {
                txtBox.Text += "Install-WindowsFeature DNS –IncludeManagementTools";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "Add-DnsServerPrimaryZone -Name \"" + DNSName + "\" -ZoneFile \"" + ZoneFile + "\"";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "Add-DnsServerForwarder -IPAddress 8.8.8.8 -PassThru";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "Add-DnsServerForwarder -IPAddress 8.8.4.4 -PassThru";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "Add-DnsServerResourceRecordA -Name \"" + ARecord + "\" -ZoneName \"" + DNSName + "\" -IPv4Address " + DNSServerIP + "";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += Environment.NewLine;
            }

            if (selected.Contains("DHCP"))
            {
                txtBox.Text += "Install-WindowsFeature DHCP -IncludeManagementTools";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "Add-DhcpServerv4Scope -Name \"" + DHCPName + "\" -StartRange " + DHCPStart + " -EndRange " + DHCPEnd + " -SubnetMask " + DHCPSub + "";
                txtBox.Text += Environment.NewLine;

                if (DHCPDNSName != null)
                {
                    txtBox.Text += "Set-DhcpServerv4OptionValue -DnsDomain " + DHCPDNSName + " -DnsServer " + DHCPDNSIP;
                    txtBox.Text += Environment.NewLine;
                    txtBox.Text += "Set-DhcpServerv4OptionValue -Router " + DHCPRouter;
                    txtBox.Text += Environment.NewLine;
                }

                txtBox.Text += "netsh dhcp server scope 10.10.10.0 set state 1";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += Environment.NewLine;
            }

            if (selected.Contains("DFS"))
            {
                txtBox.Text += "Install-WindowsFeature FS-DFS-Namespace";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += @"$folders = (’C:\dfsroots\\" + DFSName + "’)";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "mkdir -path $folders";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "$folders | ForEach-Object {$sharename = (Get-Item $_).name; New-SMBShare -Name $shareName -Path $_ -FullAccess Everyone}";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "New-DfsnRoot -Path \\" + DFSServer + " \\" + DFSName + " -TargetPath \\" + DFSServer + "\\" + DFSName + " -Type DomainV2";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += Environment.NewLine;
            }

            if (selected.Contains("AD"))
            {
                txtBox.Text += "Install-WindowsFeature AD-domain-services -IncludeManagementTools";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "Import-Module ADDSDeployment";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "Install-ADDSForest -DomainName " + Domain + " -InstallDNS -safemodeadministratorpassword (convertto-securestring \"" + Pass + "\" -asplaintext -force) -force:$true";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += Environment.NewLine;
            }

            if (selected.Contains("IIS"))
            {
                txtBox.Text += "add-windowsfeature web-server";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += Environment.NewLine;
            }

            if (selected.Contains("WDS"))
            {
                txtBox.Text += "add-windowsfeature wds";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += Environment.NewLine;
            }

            if (selected.Contains("WSUS"))
            {
                txtBox.Text += "Install-WindowsFeature -Name UpdateServices -IncludeManagementTools";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "New-Item -Path C: -Name WSUS -ItemType Directory";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += "sl \"C:\\Program Files\\Update Services\\Tools\"";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += ".\\wsusutil.exe postinstall CONTENT_DIR=C:\\WSUS";
                txtBox.Text += Environment.NewLine;
                txtBox.Text += Environment.NewLine;
            }

            if(selected.Length > 2)
            {
                txtBox.Text += "Restart-Computer";
            }

        }
    }
}