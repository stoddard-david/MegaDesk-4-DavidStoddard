using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_DavidStoddard
{
  public partial class MainMenu : Form
  {
    public MainMenu()
    {
      InitializeComponent();
    }

    private void AddQuotesBtn_Click(object sender, EventArgs e)
    {
      AddQuotes AddQuoteForm = new AddQuotes { Tag = this };
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
