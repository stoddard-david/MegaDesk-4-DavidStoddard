using System;
using System.Collections.Generic;

namespace MegaDesk_4_DavidStoddard
{
  public class DeskQuotes
  {
    private Desk Desk;
    private String Name;
    private DateTime QuoteDate { get; }
    private enum RushOrder
    {
      None,
      Day3,
      Day5,
      Day7
    }
    private RushOrder OrderSpeed;

    private int PriceQuote;

    private readonly int[,] RUSH_COST = new int[,] {
      {60,70,80},
      {40,50,60},
      {30,35,40}
    };
    private readonly int[] SURFACE_COST = new int[]
    {
      200,100,50,300,125
    };

    private const int BASE_PRICE = 200;

    public DeskQuotes(string name, string material, string rush, int width, int depth, int drawer)
    {
      Name = name;
      SetOrderSpeed(rush);

      Desk = new Desk(material, width, depth, drawer);
      QuoteDate = DateTime.Now;

      GetQuote();
    }

    private void GetQuote()
    {
      int quote = BASE_PRICE;

      if (Desk.Area > 1000)
        quote += (Desk.Area - 1000);

      switch (Desk.Material)
      {
        case Desk.SurfaceMaterial.Oak:
          quote = +SURFACE_COST[0];
          break;
        case Desk.SurfaceMaterial.Laminate:
          quote = +SURFACE_COST[1];
          break;
        case Desk.SurfaceMaterial.Pine:
          quote = +SURFACE_COST[2];
          break;
        case Desk.SurfaceMaterial.Rosewood:
          quote = +SURFACE_COST[3];
          break;
        case Desk.SurfaceMaterial.Veneer:
          quote = +SURFACE_COST[4];
          break;
      }

      quote = +Desk.Drawers * 50;
            
      int sizeIndex = 0;
      if (Desk.Area > 2000)
      {
        sizeIndex = 2;
      }
      else if (Desk.Area >= 1000)
      {
        sizeIndex = 1;
      }

      /*switch (rushOrder)
 case:
        '3Day'
 priceQuote += RUSH_COST[0][sizeIndex]
 break
 case:
        '5Day'
 priceQuote += RUSH_COST[1][sizeIndex]
 break
 case:
        '7Day'
 priceQuote += RUSH_COST[2][sizeIndex]
 break*/

      PriceQuote = quote;
    }

    private void SetOrderSpeed(string value)
    {
      switch (value)
      {
        case "None":
          OrderSpeed = RushOrder.None;
          break;
        case "3 Day":
          OrderSpeed = RushOrder.Day3;
          break;
        case "5 Day":
          OrderSpeed = RushOrder.Day5;
          break;
        case "7 Day":
          OrderSpeed = RushOrder.Day7;
          break;
      }
    }
  }
}
