using System.Collections;
namespace levelup.cli
{
class Character
{
    string DEFAULT_NAME="Test";
    
    public string Name{get;set;}

    public Character(string name)
    {
        if(name!=null && name !="")
        {
            this.Name = name;
        }
        else{
            this.Name = DEFAULT_NAME;
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
   // public void Move(Direction direction)
    //{
        //TODO Write logic of Move
   // }

}
}