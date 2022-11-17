using Sharprompt;
using System.Collections;
namespace levelup.cli
{
public class FakeGameMap: GameMap
{
    Position StartingPosition = new Position(0,0);
    int numPositions = 100;
    public FakeGameMap()
    {
        
    } 
    
    
    public bool IsPositionValid()
    {
        //TODO Logic to be added.
        return true;

    }
    public int GetTotalPositions()
    {
        //TODO Write logic of Move
        return 100;
    }
    public override Position CalculatePosition(Position startingPosition, GameController.DIRECTION direction)
    {
        //TODO Calculate Position
        return new Position(0,1);
      
    }
  
}
}