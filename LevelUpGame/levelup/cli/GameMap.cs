using Sharprompt;
using System.Collections;
using levelup;
namespace levelup.cli
{
public class GameMap
{
    public Position StartingPosition = new Position(new Random(9).Next(),new Random(9).Next());
    int numPositions = 100;
    
    public GameMap()
    {
        
    } 
    public virtual Position CalculatePosition(Position startingPosition, GameController.DIRECTION direction)
    {
        //TODO Calculate Position
        return new Position(0,0);
    }
    public bool IsPositionValid()
    {
        //TODO Logic to be added.
        return false;

    }
    public int GetTotalPositions()
    {
        //TODO Write logic of Move
        return 0;
    }
    

}
}