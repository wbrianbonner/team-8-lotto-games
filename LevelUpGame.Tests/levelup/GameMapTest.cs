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
        public void CalculatePosition()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
           Position position = new Position(0,0);
           Position ExpectedPosition = new Position(0,1);
           GameController.DIRECTION direction = GameController.DIRECTION.NORTH;
           Position newPosition = testObj.CalculatePosition(position,direction);
            Assert.AreEqual(newPosition.coordinates.X,ExpectedPosition.coordinates.X);
            Assert.AreEqual(newPosition.coordinates.Y,ExpectedPosition.coordinates.Y);
        }
    }
}