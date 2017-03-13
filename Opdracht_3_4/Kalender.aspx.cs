using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kalender : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLeeftijd_Click(object sender, EventArgs e)
    {
        //Variabelen aanmaken geselecteerde geboortedag
        DateTime geboortedatum = kalVerjaardag.SelectedDate;
        //Variabel aanmaken vandaag
        DateTime vandaag = DateTime.Now;
        //Aftrekken van geselecteerde dag met welke dag het vandaag is
        TimeSpan jaren = vandaag.Subtract(geboortedatum);
        //Totale dagen in de timespan tussen "geboortedatum" en "vandaag"
        var dagenJaren = jaren.TotalDays;
        //Bereken aantal dagen naar jaren
        var resultaatJaren = dagenJaren / 365;
        //Resultaat van berekening zetten in een label "#." achter de resultaatJaren is om de double te formateren zodat 
        lblLeeftijd.Text = resultaatJaren.ToString("#.") + " Jaren oud";
        lblDatum.Text = geboortedatum.ToString("dd-MM-yyyy");
    }

    protected void btnVervers_Click(object sender, EventArgs e)
    {
        //Welke dag en uur aangeven in de literal
        litVandaag.Text = DateTime.Now.ToString("dd-MM-yyyy");
        litTijd.Text = DateTime.Now.ToString("HH:mm");

        //Aanmaken variabelen voor de datum van pasen
        DateTime pasen = new DateTime(2017, 04, 016);
        //Timespan tussen vandaag berekenen
        TimeSpan ts = pasen.Subtract(DateTime.Now);
        //Dagen als uren laten zien
        var urenNaarDagen = Convert.ToInt32(ts.TotalHours);

        //Weergeven van de resterende tijd in de tabel op de site
        lblUren.Text = urenNaarDagen + " Uren";
        lblMinuten.Text = ts.ToString("mm' Minuten'");
        lblSeconden.Text = ts.ToString("ss' Seconden'");


    }
}