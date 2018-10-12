using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDesk_4_DavidStoddard
{
  public partial class DisplayQuote : Form
  {
    private List<DeskQuotes> QuotesList = new List<DeskQuotes>();
    private bool CancelPress = false;

    //Get the list of quotes
    public DisplayQuote(List<DeskQuotes> quotesList)
    {
      QuotesList = quotesList;
      InitializeComponent();
    }

    //Close the application
    private void cancelBtn_Click(object sender, EventArgs e)
    {
      var MainMenu = (MainMenu)Tag;
      MainMenu.Show();
      CancelPress = true;
      Close();
    }

    private void SubFormClosing(object sender, FormClosedEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && !CancelPress)
      {
        Environment.Exit(1);
      }
    }

    private void DisplayInfo(object sender, EventArgs e)
    {
      if (QuotesList.Count > 0)
      {
        DeskQuotes quote = QuotesList[QuotesList.Count - 1];
        NameLbl.Text = quote.Name;
        DateLbl.Text = quote.QuoteDate.ToString("MM-dd-yyyy");
        MaterialLbl.Text = "Material: " + quote.Desk.Material.ToString();

        if (quote.Desk.Drawers != 1)
          DrawersLbl.Text = quote.Desk.Drawers.ToString() + " Drawers";
        else
          DrawersLbl.Text = quote.Desk.Drawers.ToString() + " Drawer";

        WidthLbl.Text = "Width: " + quote.Desk.Width.ToString() + " in";
        DepthLbl.Text = "Depth: " + quote.Desk.Depth.ToString() + " in";
        AreaLbl.Text = "Total Area: " + quote.Desk.Area.ToString() + " in\x00B2";

        string rushText;
        switch (quote.OrderSpeed) {
          case DeskQuotes.RushOrder.None:
            rushText = "No Rush Shipping";
            break;
          case DeskQuotes.RushOrder.Day3:
            rushText = "3 Day Rush Shipping";
            break;
          case DeskQuotes.RushOrder.Day5:
            rushText = "5 Day Rush Shipping";
            break;
          case DeskQuotes.RushOrder.Day7:
            rushText = "7 Day Rush Shipping";
            break;
          default:
            rushText = "None";
            break;
        }
        RushLbl.Text = rushText;

        QuoteLbl.Text = "QUOTE: $" + quote.PriceQuote.ToString();
      }
      else
      {
        NameLbl.Text = "";
        DateLbl.Text = "";
        MaterialLbl.Text = "";
        DrawersLbl.Text = "";
        WidthLbl.Text = "";
        DepthLbl.Text = "";
        AreaLbl.Text = "";
        QuoteLbl.Text = "No quote was found.";
      }
    }
  }
}
