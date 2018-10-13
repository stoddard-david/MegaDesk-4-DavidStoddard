using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;


namespace MegaDesk_4_DavidStoddard
{
  public partial class AddQuotes : Form
  {
    //Variables
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

    //Constants
    private const string FILE_NAME = @"quotes.txt";

    //Constructor
    public AddQuotes(List<DeskQuotes> quotesList)
    {
      QuotesList = quotesList;
      InitializeComponent();
    }

    //Cancel button goes to main menu
    private void cancelBtn_Click(object sender, EventArgs e)
    {
      var MainMenu = (MainMenu)Tag;
      MainMenu.Show();
      CancelPress = true;
      Close();
    }

    //Checks for closing application
    private void SubFormClosing(object sender, FormClosedEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && !CancelPress)
      {
        Environment.Exit(1);
      }
    }

    //Checks the value
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

    //Validates the width
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

    //When Validated then reset the error
    private void widthVal_Validated(object sender, EventArgs e)
    {
      // If all conditions have been met, clear the ErrorProvider of errors.
      widthErrorProvider.SetError(widthVal, "");
    }

    //Validate the size of based on the min and max passed
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

    //Checks when key is pressed that only numbers are entered
    private void depthVal_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    //Validates and creates DeskQuote object
    private void AddQuotesBtn_Click(object sender, EventArgs e)
    {
      bool noError = true;
      NameNote.Text = "";
      MaterialNote.Text = "";
      IntNote.Text = "";

      string nameInput = nameBox.Text;
      if (nameBox.Text == ""){
        NameNote.Text = "Please enter name";
        noError = false;
      }

      string materialInput = materialSelect.Text;
      if (!CheckMaterial(materialInput))
      {
        MaterialNote.Text = "Select material";
        noError = false;
      }

      string rushInput = rushOrderVal.Text;
      if (!checkRush(rushInput))
      {
        RushNote.Text = "Select order speed";
        noError = false;
      }

      int widthInput = 0;
      int depthInput = 0;
      int drawersInput = 0;
      try
      {
        widthInput = Convert.ToInt32(widthVal.Value);
        depthInput = Convert.ToInt32(depthVal.Value);
        drawersInput = Convert.ToInt32(numberDrawersVal.Value);
      }
      catch
      {
        IntNote.Text = "Enter Valid Number";
        noError = false;
      }

      if (noError)
      {
        DeskQuotes desk = new DeskQuotes(nameInput, materialInput, rushInput, widthInput, depthInput, drawersInput);
        QuotesList.Add(desk);

        AddQuoteToFile(desk);

        //Open the quote
        DisplayQuote DisplayQuoteForm = new DisplayQuote(QuotesList) { Tag = (MainMenu)Tag };
        DisplayQuoteForm.Show((MainMenu)Tag);
        CancelPress = true;
        Close();
      }

    }

    //Add quote to external file
    public void AddQuoteToFile(DeskQuotes desk)
    {
      try
      {
        string deskCommaFormat;
        deskCommaFormat = desk.Name + ",";
        deskCommaFormat += desk.Desk.Material.ToString() + ",";
        deskCommaFormat += desk.OrderSpeed.ToString() + ",";
        deskCommaFormat += desk.Desk.Width.ToString() + ",";
        deskCommaFormat += desk.Desk.Depth.ToString() + ",";
        deskCommaFormat += desk.Desk.Drawers.ToString() + ",";
        deskCommaFormat += desk.QuoteDate.ToString() + ",";
        deskCommaFormat += desk.PriceQuote.ToString();

        using (var writer = new StreamWriter(FILE_NAME, true))
        {
          writer.WriteLine(deskCommaFormat);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Unable to save to file\n" + ex);
      }
    }

    //Checks the marterial
    private bool CheckMaterial(string material)
    {
      switch (material)
      {
        case "Oak":
        case "Laminate":
        case "Pine":
        case "Rosewood":
        case "Veneer":
          return true;
        default:
          return false;
      }
    }

    //Checsk the rush variable
    private bool checkRush(string rushSpeed)
    {
      switch (rushSpeed)
      {
        case "None":
        case "3 Day":
        case "5 Day":
        case "7 Day":
          return true;
        default:
          return false;
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
      materialSelect.SelectedIndex = 0;
      rushOrderVal.SelectedIndex = 0;
    }


  }
}
