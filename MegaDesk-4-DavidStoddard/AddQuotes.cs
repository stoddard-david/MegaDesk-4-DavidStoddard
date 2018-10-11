using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MegaDesk_4_DavidStoddard
{
  public partial class AddQuotes : Form
  {
    private bool CancelPress = false;
    private enum Material
    {
      Oak,
      Laminate,
      Pine,
      Rosewood,
      Veneer
    }

    public AddQuotes()
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

    private void value_Enter(object sender, EventArgs e)
    {
      //Select the whole answer in the NumbericUpDown control
      NumericUpDown valueBox = sender as NumericUpDown;

      if (valueBox != null)
      {
        int lengthOfAnswer = valueBox.Value.ToString().Length;
        valueBox.Select(0, lengthOfAnswer);
      }
    }

    private void widthVal_Validating(object sender, CancelEventArgs e)
    {
      string errorMsg;
      if (!ValidSize(widthVal.Text, 24, 96, out errorMsg))
      {
        // Cancel the event and select the text to be corrected by the user.
        e.Cancel = true;
        widthVal.Select(0, widthVal.Text.Length);

        // Set the ErrorProvider error with the text to display. 
        this.widthErrorProvider.SetError(widthVal, errorMsg);
      }
    }

    private void widthVal_Validated(object sender, EventArgs e)
    {
      // If all conditions have been met, clear the ErrorProvider of errors.
      widthErrorProvider.SetError(widthVal, "");
    }

    public bool ValidSize(string numberValue, int min, int max, out string errorMessage)
    {
      // Confirm that the email address string is not empty.
      if (numberValue == null )
      {
        errorMessage = "A number is required.";
        return false;
      }

      int validValue;

      if (Int32.TryParse(numberValue, out validValue))
      {
        if (validValue < min)
        {
          errorMessage = "The number must at least be " + min + ".";
          return false;
        } else if (validValue > max) {
          errorMessage = "The number must at most be " + max + ".";
          return false;
        } else {
          errorMessage = "";
          return true;
        }
      } else
      {
        errorMessage = "An integer is required.";
        return false;
      }
    }

    private void depthVal_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    private void AddQuotesBtn_Click(object sender, EventArgs e)
    {
      string nameInput = nameBox.Text;
      string materialInput = checkMaterial(materialSelect.Text);

    }

    private string checkMaterial(string material)
    {
      switch (material)
      {
        case "Oak":
        case "Laminate":
        case "Pine":
        case "Rosewood":
        case "Veneer":
          return material;
        default:
          return "Undefined material";
      }
    }

  }
}
