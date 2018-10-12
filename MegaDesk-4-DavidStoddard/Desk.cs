namespace MegaDesk_4_DavidStoddard
{
  public class Desk
  {
    //Set the enum
    public enum SurfaceMaterial
    {
      Oak = 0,
      Laminate = 1,
      Pine = 2,
      Rosewood = 3,
      Veneer = 4
    }

    //Variables
    public int Width { get; private set; }
    public int Depth { get; private set; }
    public int Drawers { get; private set; }
    public int Area { get; }

    public SurfaceMaterial Material { get; private set; }

    //Constructor
    public Desk(string material, int width, int depth, int drawer)
    {
      SetSurfaceMaterial(material);
      Width = width;
      Depth = depth;
      Drawers = drawer;
      Area = depth * width;
    }

    //Set SurfaceMaterial
    public void SetSurfaceMaterial(string value)
    {
      switch (value)
      {
        case "Oak":
          Material = SurfaceMaterial.Oak;
          break;
        case "Laminate":
          Material = SurfaceMaterial.Laminate;
          break;
        case "Pine":
          Material = SurfaceMaterial.Pine;
          break;
        case "Rosewood":
          Material = SurfaceMaterial.Rosewood;
          break;
        case "Veneer":
          Material = SurfaceMaterial.Veneer;
          break;
      }
    }

  }
}
