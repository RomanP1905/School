using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reken : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOptel_Click(object sender, EventArgs e)
    {
        decimal get1;
        decimal get2;
        decimal uitkomst;
        get1 = Convert.ToDecimal(txtGetal1.Text);
        get2 = Convert.ToDecimal(txtGetal2.Text);
        uitkomst = get1 + get2;
        txtUitkomst.Text = Convert.ToString(uitkomst);

    }

    protected void btnAftrek_Click(object sender, EventArgs e)
    {
        decimal get1;
        decimal get2;
        decimal uitkomst;
        get1 = Convert.ToDecimal(txtGetal1.Text);
        get2 = Convert.ToDecimal(txtGetal2.Text);
        uitkomst = get1 - get2;
        txtUitkomst.Text = Convert.ToString(uitkomst);
    }

   
}