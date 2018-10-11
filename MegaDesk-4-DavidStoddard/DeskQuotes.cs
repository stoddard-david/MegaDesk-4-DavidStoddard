using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_DavidStoddard
{
  class DeskQuotes
  {
    private Desk Desk;
    String Name;
    private DateTime quoteDate { get; }
    private enum rushOrder
    {
      None,
      Day3,
      Day5,
      Day7
    }
    private int priceQuote;

    private readonly int[,] RUSH_COST = new int[,] {
      {60,70,80},
      {40,50,60},
      {30,35,40}
    };
  }
}
