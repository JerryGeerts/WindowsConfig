using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WindowsConfig
{
    public partial class DhcpOptional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.DefaultButton = btnForward.UniqueID;
        }

        protected void btnBackward_Click(object sender, EventArgs e)
        {

        }

        protected void btnForward_Click(object sender, EventArgs e)
        {

        }
    }
}