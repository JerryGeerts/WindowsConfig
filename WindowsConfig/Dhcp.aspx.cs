using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WindowsConfig
{
    public partial class Dhcp : System.Web.UI.Page
    {
        string server;
        string name;
        string RoleSyntax;
        protected void Page_Load(object sender, EventArgs e)
        {
            server = Request.QueryString["Server"];
            name = Request.QueryString["Name"];
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            Response.Redirect("Roles.aspx?Server=" + server + "&Name=" + name);
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (txtScope.Text != "" && revScope.IsValid)
            {
                if (txtStart.Text != "" && revStart.IsValid)
                {
                    if (txtEnd.Text != "" && revEnd.IsValid)
                    {
                        if (txtRouter.Text != "" && revRouter.IsValid)
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
}