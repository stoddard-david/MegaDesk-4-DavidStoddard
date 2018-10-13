using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDesk_4_DavidStoddard
{
  public partial class MainMenu : Form
  {
    private List<DeskQuotes> QuotesList = new List<DeskQuotes>();

    public MainMenu()
    {
      InitializeComponent();
    }

    //Opens the add quotes form
    private void AddQuotesBtn_Click(object sender, EventArgs e)
    {
      AddQuotes AddQuoteForm = new AddQuotes(QuotesList) { Tag = this };
      AddQuoteForm.Show(this);
      Hide();
    }

    private void ViewQuotesBtn_Click(object sender, EventArgs e)
    {
      ViewAllQuotes ViewQuotesForm = new ViewAllQuotes { Tag = this };
      ViewQuotesForm.Show(this);
      Hide();
    }

    //Opens the search form
    private void SearchQuotesBtn_Click(object sender, EventArgs e)
    {
      SearchQuotes SearchQuotesForm = new SearchQuotes(QuotesList) { Tag = this };
      SearchQuotesForm.Show(this);
      Hide();
    }

    //Exits the application
    private void ExitBtn_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
