using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WindowsConfig
{
    public partial class Roles : System.Web.UI.Page
    {
        string server;
        string name;
        string syntax;


        protected void Page_Load(object sender, EventArgs e)
        {
            server = Request.QueryString["Server"];
            name = Request.QueryString["Name"];
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            Response.Redirect("Name.aspx?Server=" + server);
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            foreach (ListItem item in cblLeft.Items)
            {
                if (item.Selected)
                {
                    syntax += item.Value;
                }
            }
            foreach (ListItem item in cblRight.Items)
            {
                if (item.Selected)
                {
                    syntax += item.Value;
                }
            }
            foreach (ListItem item in cblMiddle.Items)
            {
                if (item.Selected)
                {
                    syntax += item.Value;
                }
            }

            string[] selected = syntax.Split(';');

            foreach(string x in selected)
            {
                if (x.Contains("DHCP"))
                {
                    lblError.Text = "yay";
                }
            }
        }
    }
}