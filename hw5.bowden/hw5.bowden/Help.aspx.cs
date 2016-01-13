using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hw5.bowden
{
    public partial class Help : System.Web.UI.Page
    {
        //transfer page to InterestCalculator Page
        protected void btnOK_Click(object sender, EventArgs e)
        {
            Response.Redirect("InterestCalculator.aspx");
        }//end btnOK_Click
    }
}