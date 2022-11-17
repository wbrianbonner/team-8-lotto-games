using System.Collections;
namespace levelup.cli
{
public class Character
{
    string DEFAULT_NAME="Beavis";
    
    public virtual string Name{get;set;}

    public Character(string name)
    {
        if(name != null || name != "")
        {
            this.Name = name;
        }
        else{
                    this.Name = DEFAULT_NAME;
             }
  
    }
    public Character()
    {

    }

    public void EnterMap()
    {
        //TODO EnterMap
    }

    public void CurrentPos()
    {
        //TODO Return type should be position.
    }
    public virtual string GetName()
    {
        return this.Name;
    }
   // public void Move(Direction direction)
    //{
        //TODO Write logic of Move
   // }

}
}