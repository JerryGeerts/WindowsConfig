using System;
using System.Web.UI;

namespace WindowsConfig
{
    public partial class Name : System.Web.UI.Page
    {
        private string server;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.DefaultButton = btnForward.UniqueID;
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            Response.Redirect("Server.aspx");
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            server = Request.QueryString["Server"];
            Page.Validate();
            if (txtName.Text != "" && RegularExpressionValidator1.IsValid)
            {
                Response.Redirect("Network.aspx?Server=" + server + "&SName=" + txtName.Text);
            }
            else
            {
                lblError.Text = "Please enter a valid name that you would like to give your server";
            }
        }
    }
}