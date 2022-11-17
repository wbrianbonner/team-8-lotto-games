using Sharprompt;
using System.Collections;
namespace levelup.cli
{
class FakeGameMap: GameMap
{
    Position startingPosition = new Position(0,0);
    int numPositions = 100;
    public FakeGameMap()
    {
        
    } 
    //public void CalculatePosition(Position startingPosition, Direction direction)
    //{
        //TODO Calculate Position
   // }
    public bool IsPositionValid()
    {
        //TODO Logic to be added.
        return true;

    }
    public int GetTotalPositions()
    {
        //TODO Write logic of Move
        return 0;
    }

}
}