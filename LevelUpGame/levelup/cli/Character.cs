using Sharprompt;
using System.Collections;
namespace levelup.cli;
{
class Character
{
    static string DEFAULT_NAME;
    
    public string Name{get;set;}

    public Character(string name)
    {
        if(string.isNullorEmpty(name))
        {
            this.Name = name;
        }
    } 
    public void EnterMap()
    {
        //TODO EnterMap
    }
    public void CurrentPos()
    {
        //TODO Return type should be position.
    }
    public void Move(Direction direction)
    {
        //TODO Write logic of Move
    }

}
}