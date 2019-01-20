using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MulServiceReference;

public partial class MulForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MulServiceClient MSC = new MulServiceClient("BasicHttpBinding_IMulService");
        Response.Write(MSC.Mul(5, 5));
    }
}