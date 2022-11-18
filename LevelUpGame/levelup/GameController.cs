using System.Drawing;
using levelup.cli;

namespace levelup
{
    public class GameController
    {
        
        // TODO: If your stakeholder wants to call this CHARACTER, change var name for
        // low representational gap
        public readonly string DEFAULT_CHARACTER_NAME = "Character";
        private Character character;
        private GameMap map;
        public record struct GameStatus(
            // TODO: Add other status data
            String characterName,
            Point currentPosition
        );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            status.currentPosition = new Point(-1,-1);
        }

        public void SetCharacterPosition(Point coordinates)
        {

        }

        // Pre-implemented to demonstrate ATDD
        // TODO: Update this if it does not match your design
        public void CreateCharacter(String name)
        {
           
            if (name != null && !name.Equals(""))
            {
                this.status.characterName = name;
            }
            else
            {
                this.status.characterName = DEFAULT_CHARACTER_NAME;
            }
             character = new Character(this.status.characterName);
        }

        public void StartGame()
        {
            character.EnterMap(new GameMap());
            this.status.currentPosition = character.CurPosition.coordinates;

        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
        }




    }
}