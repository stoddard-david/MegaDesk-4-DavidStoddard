using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_4_DavidStoddard
{
  public partial class MainMenu : Form
  {
    private List<DeskQuotes> QuotesList = new List<DeskQuotes>();

    //Constant
    private const string FILE_NAME = @"quotes.txt";

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

    //Opens the View all quotes
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

    //When load form, then Load the values into the list
    private void LoadList(object sender, EventArgs e)
    {
      try
      {
        //Load if file exist
        if (File.Exists(FILE_NAME))
        {
          using (StreamReader reader = new StreamReader(FILE_NAME))
          {
            while (!reader.EndOfStream)
            {
              string[] quoteField = reader.ReadLine().Split(',');
              try
              {
                string name = quoteField[0];
                string material = quoteField[1];
                string rush = quoteField[2];
                int width = Int32.Parse(quoteField[3]);
                int depth = Int32.Parse(quoteField[4]);
                int drawer = Int32.Parse(quoteField[5]);
                DateTime time = DateTime.Parse(quoteField[6]);
                int price = Int32.Parse(quoteField[7]);

                DeskQuotes desk = new DeskQuotes(name, material, rush, width, depth, drawer, time, price);
                QuotesList.Add(desk);
              }
              catch (Exception ex1)
              {
                MessageBox.Show("Error: Can't creating the quote record.\n" + ex1);
              }
            }
          }
        }
      } catch (Exception ex)
      {
        MessageBox.Show("Error: Unable to read quote records.\n" + ex);
      }
    }
  }
}
