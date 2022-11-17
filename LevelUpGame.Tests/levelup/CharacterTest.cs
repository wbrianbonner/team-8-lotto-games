using NUnit.Framework;
using levelup;
using levelup.cli;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private TestCharacter testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new TestCharacter();
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
            var corCheck = Check(newPosition.coordinates.X) && Check(newPosition.coordinates.Y);
            Assert.IsTrue(corCheck);


#pragma warning disable CS8602 // Rethrow to preserve stack details
        }
        private bool Check(int x)
        {
            return x>=0 && x<=9;
        }
        
    }
}