using NUnit.Framework;
using levelup;
using levelup.cli;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private FakeCharacter testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new FakeCharacter();
        }

        [Test]
        public void ReturnName()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.GetName());
        }
        
        [Test]
        public void EnterMap()
        {
            FakeGameMap TestGameMap = new FakeGameMap();
            testObj.EnterMap(TestGameMap);
            var corCheck = Check(testObj.CurPosition.coordinates.X) && Check(testObj.CurPosition.coordinates.Y);
            Assert.IsTrue(corCheck);
        }

        [Test]
        public void Move(){
            testObj.CurPosition = new Position(5,5);
            Position ExpectedPosition = new Position(5,6);
            GameController.DIRECTION direction = GameController.DIRECTION.NORTH;
            testObj.Move(direction);
            Assert.AreEqual(testObj.CurPosition.coordinates.X,ExpectedPosition.coordinates.X);
            Assert.AreEqual(testObj.CurPosition.coordinates.Y,ExpectedPosition.coordinates.Y);
       }

        private bool Check(int x)
        {
  
            return x>=0 && x<=9;
        }
        
    }
}