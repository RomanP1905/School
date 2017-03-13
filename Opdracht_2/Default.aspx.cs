using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnMaakKaart_Click(object sender, EventArgs e)
    {
        // Het aanmaken van de variabelen (=Declareren)
        string Naam, Geslacht, Hobby, Opleiding;
        // Het vullen van de variabele Naam (=Initialiseren)
        // met de inhoud (Txt) van de Textbox
        Naam = txtNaam.Text;
        Geslacht = rbGeslacht.SelectedValue;
        Opleiding = cbOpleiding.SelectedValue;
        Hobby = "Hobby: ";
        if (chkHobby.SelectedValue == "1" && chkHobby.SelectedValue != "2")
        {
            Hobby += "Gamen ";
        }

        else if (chkHobby.SelectedValue == "1" && chkHobby.SelectedValue == "2")
        {
            Hobby += "Gamen + Programmeren";
        }
        else if (chkHobby.SelectedValue == "2" && chkHobby.SelectedValue != "1")
        {
            Hobby += "Programmeren";
        }
        else
        {
            Hobby += "Geen hobby";
        }

        // ik gebruik hier een label ipv Response.Write om makkelijker controle te hebben over waar de output komt
        Label1.Text = "Naam: " + Naam + "<br />" + Hobby + "<br />" + "Opleiding: " + Opleiding + "<br />" + "Geslacht: " + Geslacht + "<br />";
    }


    protected void radShow1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Panel controls
        if (radShow1.SelectedValue == "1")
        {
            Panel1.Visible = true;
        }
        if (radShow1.SelectedValue == "2")
        {
            Panel1.Visible = false;
        }
    }
}
