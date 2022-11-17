using Sharprompt;
using System.Collections;
namespace levelup.cli
{
class TestCharacter: Character
{    
    public void EnterMap()
    {
        //TODO EnterMap
    }

    public Position CurrentPos()
    {
        return new Position(0,0);
    }
    public override string GetName()
    {
        return "Fake Character";
    }
    

//    public void Move(Direction direction)
//    {
//        //TODO Write logic of Move
//    }

}
}