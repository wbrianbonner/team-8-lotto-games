using System.Collections;
namespace levelup.cli
{
public class Character
{
    string DEFAULT_NAME="Quark";
    
    public virtual string Name{get;set;}
    public Position CurPosition{get;set;}
    private GameMap map = new GameMap{};

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

    public Position EnterMap(GameMap map)
    {
        return map.StartingPosition;
    }

    public virtual Position GetCurPosition()
    {
        return this.CurPosition;
    }

    public virtual string GetName()
    {
        return this.Name;
    }

    public void Move(GameController.DIRECTION direction)
    {
        this.CurPosition = map.CalculatePosition(GetCurPosition(),direction);
    }

}
}