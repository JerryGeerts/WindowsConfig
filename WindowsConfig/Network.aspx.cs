using System;
using System.Web.UI;

namespace WindowsConfig
{
    public partial class Network : System.Web.UI.Page
    {
        private string server;
        private string name;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.DefaultButton = btnForward.UniqueID;
            server = Request.QueryString["Server"];
            name = Request.QueryString["SName"];
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            Response.Redirect("Name.aspx?Server=" + server);
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (txtIP4.Text != "" && revIP4.IsValid)
            {
                if (txtSub.Text != "" && revSubnet.IsValid)
                {
                    if (txtGate.Text != "" && revGate.IsValid)
                    {
                        if (txtDNS.Text != "" && revDNS.IsValid)
                        {
                            Response.Redirect("Roles.aspx?Server=" + server + "&SName=" + name + "&NWIP4=" + txtIP4.Text + "&NWSub=" + txtSub.Text + "&NWGate=" + txtGate.Text + "&NWDNS=" + txtDNS.Text);
                        }
                        else
                        {
                            lblError.Text = "Please enter a valid DNS address";
                        }
                    }
                    else
                    {
                        lblError.Text = "Please enter a valid Gateway address";
                    }
                }
                else
                {
                    lblError.Text = "Please enter a valid Subnet address";
                }
            }
            else
            {
                lblError.Text = "Please enter a valid IP4 address";
            }
        }
    }
}