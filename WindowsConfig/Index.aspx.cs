using System;

namespace WindowsConfig
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnWizzard_Click(object sender, EventArgs e)
        {
            Response.Redirect("Server.aspx");
        }
    }
}