using Sharprompt;
using System.Collections;
namespace levelup.cli
{
class FakeCharacter: Character
{    
   
    public override Position GetCurPosition()
    {
        return null;
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