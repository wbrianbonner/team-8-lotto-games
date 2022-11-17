using System.Drawing;
namespace levelup.cli
{
public class Position
{    
    public Point coordinates;

    public Position(int xCoordinates, int yCoordinates)
    {
      this.coordinates.X = xCoordinates;
      this.coordinates.Y = yCoordinates;
    } 
}
}