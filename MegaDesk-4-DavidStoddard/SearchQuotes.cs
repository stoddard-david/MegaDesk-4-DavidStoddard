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
  public partial class SearchQuotes : Form
  {
    private bool CancelPress = false;

    public SearchQuotes()
    {
      InitializeComponent();
    }

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
  }
}
