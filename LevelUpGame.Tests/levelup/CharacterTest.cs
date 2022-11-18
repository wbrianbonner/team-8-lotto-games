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
            Position newPosition = testObj.EnterMap(TestGameMap);
            TestContext.Out.WriteLine(newPosition.coordinates.X);
            TestContext.Out.WriteLine(newPosition.coordinates.Y);
            var corCheck = Check(newPosition.coordinates.X) && Check(newPosition.coordinates.Y);
            TestContext.Out.WriteLine(corCheck);
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