using NUnit.Framework;
using levelup;
using levelup.cli;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private FakeGameMap? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new FakeGameMap();
        }
        [Test]
        public void CalculatePositionNORTHDirection()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
           Position position = new Position(0,0);
           Position ExpectedPosition = new Position(0,1);
           GameController.DIRECTION direction = GameController.DIRECTION.NORTH;
           Position newPosition = testObj.CalculatePosition(position,direction);
            Assert.AreEqual(newPosition.coordinates.X,ExpectedPosition.coordinates.X);
            Assert.AreEqual(newPosition.coordinates.Y,ExpectedPosition.coordinates.Y);
        }
         [Test]
        public void CalculatePositionSOUTHDirection()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
           Position position = new Position(1,1);
           Position ExpectedPosition = new Position(1,0);
           GameController.DIRECTION direction = GameController.DIRECTION.SOUTH;
           Position newPosition = testObj.CalculatePosition(position,direction);
            Assert.AreEqual(newPosition.coordinates.X,ExpectedPosition.coordinates.X);
            Assert.AreEqual(newPosition.coordinates.Y,ExpectedPosition.coordinates.Y);
        }
         [Test]
        public void CalculatePositionEASTDirection()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
           Position position = new Position(5,5);
           Position ExpectedPosition = new Position(6,5);
           GameController.DIRECTION direction = GameController.DIRECTION.EAST;
           Position newPosition = testObj.CalculatePosition(position,direction);
            Assert.AreEqual(newPosition.coordinates.X,ExpectedPosition.coordinates.X);
            Assert.AreEqual(newPosition.coordinates.Y,ExpectedPosition.coordinates.Y);
        }
          [Test]
        public void CalculatePositionWESTDirection()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
           Position position = new Position(5,5);
           Position ExpectedPosition = new Position(4,5);
           GameController.DIRECTION direction = GameController.DIRECTION.WEST;
           Position newPosition = testObj.CalculatePosition(position,direction);
            Assert.AreEqual(newPosition.coordinates.X,ExpectedPosition.coordinates.X);
            Assert.AreEqual(newPosition.coordinates.Y,ExpectedPosition.coordinates.Y);
        }
          [Test]
        public void CalculatePositionBoundaryNoMovement()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
           Position position = new Position(0,0);
           Position ExpectedPosition = new Position(0,0);
           GameController.DIRECTION direction = GameController.DIRECTION.WEST;
           Position newPosition = testObj.CalculatePosition(position,direction);
            Assert.AreEqual(newPosition.coordinates.X,ExpectedPosition.coordinates.X);
            Assert.AreEqual(newPosition.coordinates.Y,ExpectedPosition.coordinates.Y);
            
            /* TOP Right Boundary Condition Gping NORTH*/
            position = new Position(9,9);
            ExpectedPosition =  new Position(9,9);
            direction =GameController.DIRECTION.NORTH;
            newPosition = testObj.CalculatePosition(position,direction);
            Assert.AreEqual(newPosition.coordinates.X,ExpectedPosition.coordinates.X);
            Assert.AreEqual(newPosition.coordinates.Y,ExpectedPosition.coordinates.Y);
            
            /* TOP Right Boundary Condition GOING EAST*/
            position = new Position(9,9);
            ExpectedPosition =  new Position(9,9);
            direction =GameController.DIRECTION.EAST;
            newPosition = testObj.CalculatePosition(position,direction);
            Assert.AreEqual(newPosition.coordinates.X,ExpectedPosition.coordinates.X);
            Assert.AreEqual(newPosition.coordinates.Y,ExpectedPosition.coordinates.Y);
              /* TOP Right Boundary Condition GOING SOUTH*/
            position = new Position(9,0);
            ExpectedPosition =  new Position(9,0);
            direction =GameController.DIRECTION.SOUTH;
            newPosition = testObj.CalculatePosition(position,direction);
            Assert.AreEqual(newPosition.coordinates.X,ExpectedPosition.coordinates.X);
            Assert.AreEqual(newPosition.coordinates.Y,ExpectedPosition.coordinates.Y);
        }
    }
}