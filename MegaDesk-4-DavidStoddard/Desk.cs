namespace MegaDesk_4_DavidStoddard
{
  class Desk
  {
    public int Width { get; private set; }
    public int Depth { get; private set; }
    public int Drawers { get; private set; }
    public int Area { get; }
    public enum SurfaceMaterial
    {
      Oak,
      Laminate,
      Pine,
      Rosewood,
      Veneer
    }
    public SurfaceMaterial Material { get; private set; }

    public Desk(string material, int width, int depth, int drawer)
    {
      SetSurfaceMaterial(material);
      Width = width;
      Depth = depth;
      Drawers = drawer;
      Area = depth * width;
    }

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
