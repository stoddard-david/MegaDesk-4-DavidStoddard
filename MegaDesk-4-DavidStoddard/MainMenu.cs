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

    private void AddQuotesBtn_Click(object sender, EventArgs e)
    {
      AddQuotes AddQuoteForm = new AddQuotes(QuotesList) { Tag = this };
      AddQuoteForm.Show(this);
      Hide();
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ViewQuotesBtn_Click(object sender, EventArgs e)
    {
      ViewAllQuotes ViewQuotesForm = new ViewAllQuotes { Tag = this };
      ViewQuotesForm.Show(this);
      Hide();
    }

    private void SearchQuotesBtn_Click(object sender, EventArgs e)
    {
      SearchQuotes SearchQuotesForm = new SearchQuotes { Tag = this };
      SearchQuotesForm.Show(this);
      Hide();
    }
  }
}
