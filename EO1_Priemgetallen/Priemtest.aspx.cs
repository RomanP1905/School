using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Priemtest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnCheck_Click(object sender, EventArgs e)
    {
        //Zet de ingevoerde nummer in een variabel
        int priem = Convert.ToInt32(txtPriem.Text);
        //Nummers 0 en 1 kunnen nooit priem zijn dus haal ze meteen uit de berekening
        if (priem == 0 || priem == 1)
        {
            lblRes.Text = priem + " is geen priem nummer";
        }
        else
        {
            //Loop de te delen sommen
            for (int i = 2; i <= priem / 2; i++)
            {
                //Komt de modulo uit op 0 dan kan het geen priem nummer zijn want priem getallen zijn altijd oneven getallen
                if (priem % i == 0)
                {
                    lblRes.Text = priem + " is geen priem nummer";
                    return;
                }

            }
            //Het is een priem nummer als hij niet voldoet aan alle andere filters
            lblRes.Text = priem + " is een priem nummer ☺";
        }
    }


    protected void btnLijst_Click(object sender, EventArgs e)
    {
        //Maak de value leeg wanneer je op de knop drukt
        lijst.InnerHtml = "";
        //Sla de max aantal op
        int l = Convert.ToInt32(txtPriem2.Text);
        //Schrijf 2 alvast op want 0 en 1 kunnen geen priem nummers zijn en omdat de modulo methode niet werkt bij 0 
        lijst.InnerHtml += "2 <br />";
        //Loop alweer dezelfde manier 
        for (int i = 3; i <= l; i++)
        {   
            //Default is de priem true als er een conflict is waar de programma vind dat het geen priem is dan veranderd hij naar false
            bool isPriem = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    //is het geen priem ga dan verder met de volgende loop ipv doorgaan met de programma
                    isPriem = false;
                    break;
                }
            }
                //is de priem niet false dan kan de programma door om int te schrijven
                if(isPriem)
                {
                    lijst.InnerHtml += i + "<br />";
                }       
            }
        }
    }