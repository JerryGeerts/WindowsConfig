using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WindowsConfig
{
    public partial class Network : System.Web.UI.Page
    {
        string server;
        string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.DefaultButton = btnForward.UniqueID;
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            Response.Redirect("Name.aspx?Server=" + server);
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            server = Request.QueryString["Server"];
            name = Request.QueryString["Name"];
            Page.Validate();
            if (txtIP4.Text != "" && revIP4.IsValid)
            {
                if (txtSub.Text != "" && revSubnet.IsValid)
                {
                    if (txtGate.Text != "" && revGate.IsValid)
                    {
                        if (txtDNS.Text != "" && revDNS.IsValid)
                        {
                            Response.Redirect("Roles.aspx?Server=" + server + " &Name=" + name + "&IP4=" + txtIP4.Text + "&Sub=" + txtSub.Text + "&Gate=" + txtGate.Text + "&DNS=" + txtDNS.Text);
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