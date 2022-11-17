using Sharprompt;
using System.Collections;
namespace levelup.cli
{
class GameMap
{
    Position startingPosition = new Position(new Random(9).Next(),new Random(9).Next());
    int numPositions = 100;


    public GameMap()
    {
        
    } 
    //public void CalculatePosition(Position startingPosition, Direction direction)
    //{
        //TODO Calculate Position
   // }
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