using Sharprompt;
using System.Collections;
namespace levelup.cli
{
class TestCharacter: Character
{    
   
    public Position CurrentPos()
    {
        return new Position(5,5);
    }

    public override string GetName()
    {
        return "Fake Character";
    }
    
    public Position Move()
    {
        return new Position(6,5);
    }

}
}