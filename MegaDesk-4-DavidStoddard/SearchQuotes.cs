using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk_4_DavidStoddard
{
  public partial class SearchQuotes : Form
  {
    private enum Material
    {
      Oak = 0,
      Laminate = 1,
      Pine = 2,
      Rosewood = 3,
      Veneer = 4
    }

    private bool CancelPress = false;
    private List<DeskQuotes> QuotesList = new List<DeskQuotes>();

    //Initialize the form
    public SearchQuotes(List<DeskQuotes> quotesList)
    {
      QuotesList = quotesList;
      InitializeComponent();
    }

    //Closing the form
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

    //When the form loads populate material list and set defaults
    private void LoadingForm(object sender, EventArgs e)
    {
      List<string> materialsList = new List<string>();
      materialsList = Enum.GetNames(typeof(Material)).ToList();
      foreach (var Material in materialsList)
      {
        materialSelect.Items.Add(Material);
      }
    }

    //Pick a material
    private void SearchListByMaterial(object sender, EventArgs e)
    {
      try
      {
        SearchResultList.Clear();
        SearchResultList.Columns.Add("Date",50, HorizontalAlignment.Left);
        SearchResultList.Columns.Add("Name",190, HorizontalAlignment.Left);
        SearchResultList.Columns.Add("Width",61, HorizontalAlignment.Left);
        SearchResultList.Columns.Add("Depth",61, HorizontalAlignment.Left);
        SearchResultList.Columns.Add("Drawers",75, HorizontalAlignment.Left);
        SearchResultList.Columns.Add("Quote",75, HorizontalAlignment.Left);

        int countFound = 0;
        foreach (DeskQuotes quote in QuotesList)
        {
          if (quote.Desk.Material.ToString() == materialSelect.Text)
          {
            SearchResultList.Items.Add(new ListViewItem(new[] {
            quote.QuoteDate.ToString("MM/dd"),
            quote.Name,
            quote.Desk.Width.ToString(),
            quote.Desk.Depth.ToString(),
            quote.Desk.Drawers.ToString(),
            "$" + quote.PriceQuote.ToString()
            }));

            countFound++;
          }
        }
        if (countFound == 0)
        {
          SearchResultList.Clear();
          SearchResultList.Columns.Add("No records were found",517, HorizontalAlignment.Left);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error finding the records\n" + ex);
      }

    }
  }
}
