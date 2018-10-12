using System;
using System.Collections.Generic;

namespace MegaDesk_4_DavidStoddard
{
  public class DeskQuotes
  {
    //Setup enum type
    public enum RushOrder
    {
      None = 0,
      Day3 = 1,
      Day5 = 2,
      Day7 = 3
    }

    //Set up variables
    public Desk Desk;
    public String Name { get; set; }
    public DateTime QuoteDate { get; }
    public RushOrder OrderSpeed { get; set; }
    public int PriceQuote { get; private set; }

    //CONSTANTS
    private const int BASE_PRICE = 200;
    private const int DRAW_PRICE = 50;
    private const int AREA_PRICE = 1;
    private readonly int[,] RUSH_COST = new int[,] {
      {0,0,0},
      {60,70,80},
      {40,50,60},
      {30,35,40}
    };
    private readonly int[] SURFACE_COST = new int[]
    {
      200,100,50,300,125
    };

    //Constructor
    public DeskQuotes(string name, string material, string rush, int width, int depth, int drawer)
    {
      Name = name;
      SetOrderSpeed(rush);

      Desk = new Desk(material, width, depth, drawer);
      QuoteDate = DateTime.Now;

      GetQuote();
    }

    //Calculates quote
    private void GetQuote()
    {
      int quote = BASE_PRICE;

      if (Desk.Area > 1000)
        quote += (Desk.Area - 1000)* AREA_PRICE;

      switch (Desk.Material)
      {
        case Desk.SurfaceMaterial.Oak:
          quote += SURFACE_COST[0];
          break;
        case Desk.SurfaceMaterial.Laminate:
          quote += SURFACE_COST[1];
          break;
        case Desk.SurfaceMaterial.Pine:
          quote += SURFACE_COST[2];
          break;
        case Desk.SurfaceMaterial.Rosewood:
          quote += SURFACE_COST[3];
          break;
        case Desk.SurfaceMaterial.Veneer:
          quote += SURFACE_COST[4];
          break;
      }

      quote += Desk.Drawers * DRAW_PRICE;
            
      int sizeIndex = 0;
      if (Desk.Area > 2000)
      {
        sizeIndex = 2;
      }
      else if (Desk.Area >= 1000)
      {
        sizeIndex = 1;
      }

      quote += RUSH_COST[(int)OrderSpeed,sizeIndex];

      PriceQuote = quote;
    }

    //Set the Enum value of the rush order
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
