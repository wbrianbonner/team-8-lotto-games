using Sharprompt;
using System.Collections;
using levelup;
namespace levelup.cli
{
public class GameMap
{
    public Position StartingPosition = new Position(new Random().Next(9),new Random().Next(9));
    int numPositions = 100;
    
    public GameMap()
    {
        
    } 
    public virtual Position CalculatePosition(Position currPosition, GameController.DIRECTION direction)
    {
        //TODO Calculate Position
        Position newPosition = null;
        if(direction == GameController.DIRECTION.NORTH)
        {
            newPosition = new Position(currPosition.coordinates.X, currPosition.coordinates.Y +1);
        }
        else if(direction == GameController.DIRECTION.SOUTH)
        {
            newPosition = new Position(currPosition.coordinates.X, currPosition.coordinates.Y -1);
        
        }
        else if(direction == GameController.DIRECTION.EAST)
        {
             newPosition = new Position(currPosition.coordinates.X+ 1, currPosition.coordinates.Y);
        
        }
        else if(direction == GameController.DIRECTION.WEST)
        {
          newPosition = new Position(currPosition.coordinates.X-1, currPosition.coordinates.Y);
        
        }
        if(IsValidPosition(newPosition))
        {
            return newPosition;
        }
        else
        {
             return currPosition;
        }
       
      
    }
   
    public int GetTotalPositions()
    {
        //TODO Write logic of Move
        return 0;
    }
    private bool IsValidPosition(Position position)
    {
        return position.coordinates.X >=0 && position.coordinates.X <=9
               && position.coordinates.Y >=0 && position.coordinates.Y <=9;
    }
    

}
}