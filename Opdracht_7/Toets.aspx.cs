using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Toets : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStart_Click(object sender, EventArgs e)
    {
        //Bewaar namen in een array voor loop gebruik en clear alle velden 
        TextBox[] arrE = { null, txtE1, txtE2, txtE3, txtE4, txtE5 };
        Label[] arrCheck = { null, txtCheck1, txtCheck2, txtCheck3, txtCheck4, txtCheck5 };
        //loop clear
        for (int i = 1; i < 6; i++)
        {
            arrE[i].Text = "";
        }

        for (int i = 1; i < 6; i++)
        {
            arrCheck[i].Text = "";
        }
        //Maak score label leeg
        lblScore.Text = "";
        //Voer alleen iets uit als er iets ingevult is bij de max tafel
        if (txtHoogste.Text != "") {
        //vang een value voor de max variabele
        int max = Convert.ToInt32(txtHoogste.Text);
        
        

        //Maak array aan van 6 indexes
        int[] array1 = new int[6];
        //Maak een random generator aan
        Random gen = new Random();
        //Vul de array met de random getallen die de generator maakt
        for (int i = 1; i < array1.Length; i++)
        {
            array1[i] = gen.Next(1, max);
        }

            //Vul een array met alle labels die gevult moeten worden
            Label[] arrLabel1 = { null, lblSom1, lblSom2, lblSom3, lblSom4, lblSom5 };

            //for loop om de labels waardes te geven van "1 x [random nummer]" "2 x [random nummer]" etc
            for (int i = 1; i < 6; i++)
            {
                arrLabel1[i].Text = i + " x " + array1[i];
            }

            //zet de resultaten van de sommen in een array
            int[] arrRes = new int[6];
            for (int i = 1; i < 6; i++)
            {
                arrRes[i] = i * array1[i];
            }

            //Sla resultaten in een label op voor later gebruik
            Label[] arrLblRes = { null, lblRes1, lblRes2, lblRes3, lblRes4, lblRes5 };

            for (int i = 1; i < 6; i++)
            {
                arrLblRes[i].Text = Convert.ToString(arrRes[i]);
            }

        }

    }

    protected void btnEnd_Click(object sender, EventArgs e)
    {
        //Kijk of de input overeenkomt met de antwoord, bij een fout trek 2 punten van score af
        //Geef per score een rating [Uitmuntend, Goed, Voldoende, Onvoldoende]
        int score = 10;


        switch (txtE1.Text == lblRes1.Text){
            case true:
                txtCheck1.Text = "Goed";
                break;
            case false:
                txtCheck1.Text = "Fout de antwoord is: " + lblRes1.Text;
                //2 punten van score af bij fout
                score-= 2;
                break;
        }

        switch (txtE2.Text == lblRes2.Text)
        {
            case true:
                txtCheck2.Text = "Goed";
                break;
            case false:
                txtCheck2.Text = "Fout de antwoord is: " + lblRes2.Text;
                score -= 2;
                break;
        }

        switch (txtE3.Text == lblRes3.Text)
        {
            case true:
                txtCheck3.Text = "Goed";
                break;
            case false:
                txtCheck3.Text = "Fout de antwoord is: " + lblRes3.Text;
                score -= 2;
                break;
        }

        switch (txtE4.Text == lblRes4.Text)
        {
            case true:
                txtCheck4.Text = "Goed";
                break;
            case false:
                txtCheck4.Text = "Fout de antwoord is: " + lblRes4.Text;
                score -= 2;
                break;
        }

        switch (txtE5.Text == lblRes5.Text)
        {
            case true:
                txtCheck5.Text = "Goed";
                break;
            case false:
                txtCheck5.Text = "Fout de antwoord is: " + lblRes5.Text;
                score -= 2;
                break;
        }


        //Zet score in een label met een keuring [uitmuntend, goed, voldoende, onvoldoende]
        switch (score)
        {
            case 10:
            lblScore.Text = "Score: " + score + " uitmuntend!";
                lblScore.BackColor = System.Drawing.Color.DarkGreen;
                lblScore.ForeColor = System.Drawing.Color.White;
                break;
            case 8:
            lblScore.Text = "Score: " + score + " Goed";
                lblScore.BackColor = System.Drawing.Color.Green;
                lblScore.ForeColor = System.Drawing.Color.White;
                break;
            case 6:
                lblScore.Text = "Score: " + score + " Voldoende";
                lblScore.BackColor = System.Drawing.Color.Orange;
                lblScore.ForeColor = System.Drawing.Color.White;
                break;
            case 4:
            case 2:
            case 0:
                lblScore.Text = "Score: " + score + " Onvoldoende";
                lblScore.BackColor = System.Drawing.Color.Red;
                lblScore.ForeColor = System.Drawing.Color.White;
                break;
        }
        
    }

    protected void btnDebug_Click(object sender, EventArgs e)
    {
        if (Panel1.Visible == false)
        {
            Panel1.Visible = true;
        }
        else
        {
            Panel1.Visible = false;
        }
    }
}