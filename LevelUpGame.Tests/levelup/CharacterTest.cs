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
    }
}