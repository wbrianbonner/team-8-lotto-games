using System.Drawing;
namespace levelup.cli
{
public class Position
{    
    public Point coordinates;

    public Position(int xCoordinates, int yCoordinates)
    {
      coordinates = new Point(xCoordinates,yCoordinates);
    } 
}
}