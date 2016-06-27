using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WindowsConfig
{
    public partial class Server : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.DefaultButton = btnForward.UniqueID;
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex >= 0)
            {
                Response.Redirect("Name.aspx?Server=" + RadioButtonList1.SelectedValue);
            }
            else
            {
                lblError.Text = "Please select the OS of the server you are trying to configure";
            }
        }
    }
}