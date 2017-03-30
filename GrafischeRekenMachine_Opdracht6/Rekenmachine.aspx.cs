using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Rekenmachine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }





    protected void btn2_Click(object sender, EventArgs e)
    {
        // controlleer of er minder dan 7 tekens staan in de display en of de eerste cijfer niet een 0 is
        //Wiskundige getallen kunnen niet met een 0 beginnen tenzij er meteen een punt volgt om aan te geven dat het een decimaal is
        if (txtScherm.Text != "0" && txtScherm.Text.Length < 7)
        {
            //Voeg aan het einde van de string een string "2" toe
            txtScherm.Text += "2";
        }
    }

    //het zelfde verhaal voor alle knoppen 0-9
    protected void btn3_Click(object sender, EventArgs e)
    {
        
        if (txtScherm.Text != "0" && txtScherm.Text.Length < 7)
        {
            txtScherm.Text += "3";
        }
    }

    protected void btn4_Click(object sender, EventArgs e)
    {
        
        if (txtScherm.Text != "0" && txtScherm.Text.Length < 7)
        {
            txtScherm.Text += "4";
        }
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
        
        if (txtScherm.Text != "0" && txtScherm.Text.Length < 7)
        {
            txtScherm.Text += "5";
        }
    }

    protected void btn6_Click(object sender, EventArgs e)
    {
        
        if (txtScherm.Text != "0" && txtScherm.Text.Length < 7)
        {
            txtScherm.Text += "6";
        }
    }

    protected void btn7_Click(object sender, EventArgs e)
    {
        
        if (txtScherm.Text != "0" && txtScherm.Text.Length < 7)
        {
            txtScherm.Text += "7";
        }
    }

    protected void btn8_Click(object sender, EventArgs e)
    {
        
        if (txtScherm.Text != "0" && txtScherm.Text.Length < 7)
        {
            txtScherm.Text += "8";
        }
    }

    protected void btn9_Click(object sender, EventArgs e)
    {
        
        if (txtScherm.Text != "0" && txtScherm.Text.Length < 7)
        {
            txtScherm.Text += "9";
        }
    }


    protected void btn1_Click(object sender, EventArgs e)
    {
        
        if (txtScherm.Text != "0" && txtScherm.Text.Length < 7)
        {
            txtScherm.Text += "1";
        }
    }

    protected void btn0_Click(object sender, EventArgs e)
    {
        
        if (txtScherm.Text != "0" && txtScherm.Text.Length < 7)
        {
            txtScherm.Text += "0";
        }

    }

    protected void btnPunt_Click(object sender, EventArgs e)
    {
        //Check of er al een punt staat in de textbox (je kan niet 2 punten hebben in een decimaal getal)
        if (txtScherm.Text.Contains(".") != true)
        {
            if (txtScherm.Text.Length == 0)
            {
                txtScherm.Text += "0.";
            }
            else
            {
                txtScherm.Text += ".";
            }
        }
    }

    protected void btnPlus_Click(object sender, EventArgs e)
    {
        //Zet getal op scherm in een label voor later gebruik in de btnIs_Click functie
        lGetal1.Text = txtScherm.Text;
        //Maak scherm schoon
        txtScherm.Text = string.Empty;
        //Zet de waarde "+" in een label 
        lBereken.Text = "+";
    }
    protected void btnMin_Click(object sender, EventArgs e)
    {
        //Zelfde verhaal als de plus functie
        lGetal1.Text = txtScherm.Text;
        txtScherm.Text = string.Empty;
        lBereken.Text = "-";
    }

    protected void btnIs_Click(object sender, EventArgs e)
    {
        //Check of er een waarde staat in lGetal1 en voer daarna pas de berekening uit 
        //als er geen waarde is crasht de programma omdat met als waarde null je geen berekeningen kunt maken
        if (lGetal1 != null && lGetal1.Text.Length != 0)
        {
            //plaats doubles in variabelen
            double G1 = Convert.ToDouble(txtScherm.Text);
            double G2 = Convert.ToDouble(lGetal1.Text);
            //geef een standaard variabele aan voor de uitkomst
            double uitkomst = 0;
            //maak berekening plus als er in de lBereken label een waarde + is
            if (lBereken.Text == "+")
            {
                uitkomst = G1 + G2;
            }
            //anders maakt je een berekening min als de waarde een - is
            else if (lBereken.Text == "-")
            {

                uitkomst = G2 - G1;
            }
            // Plaats uitkomst van berekening in scherm
            txtScherm.Text = uitkomst.ToString();
            //Disable de back knop nadat er een berekening staat
            btnBack.Enabled = false;
        }
    }



    protected void btnC_Click(object sender, EventArgs e)
    {
        //Clear scherm en alle variabelen
        txtScherm.Text = string.Empty;
        lGetal1.Text = string.Empty;
        lBereken.Text = string.Empty;
        //Enable de knop als je op C drukt
        btnBack.Enabled = true;
    }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        
        // controlleer of er minder dan 0 tekens staan in de display
        // Je mag geen lengte van de string weghalen als het al op 0 lengte is
        if (txtScherm.Text.Length > 0)
        {
            //Verwijder 1 lengte van de string die wordt weergegeven op het scherm
            txtScherm.Text = txtScherm.Text.Remove(txtScherm.Text.Length - 1);
        }
    }
}