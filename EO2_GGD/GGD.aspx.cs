using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GGD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCheck_Click(object sender, EventArgs e)
    {

        int num1 = Convert.ToInt32(txtNum1.Text);
        int num2 = Convert.ToInt32(txtNum2.Text);
        int over;
        //blijf deze 3 statements loopen tot je op 0 modulo uitkomt, dit betekent dat het getal dat het laatst kwam de GGD is.
        while (num2 != 0)
        {
            over = num1 % num2;
            num1 = num2;
            num2 = over;
        }
        lblGGD.Text = Convert.ToString(num1);
    }
}