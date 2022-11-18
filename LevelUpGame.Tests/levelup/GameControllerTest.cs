using NUnit.Framework;
using levelup;
using levelup.cli;

namespace levelup
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private GameController? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.GetStatus());
        }
         [Test]
        public void IsCharacterCreated()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.CreateCharacter("Test Character");
            Assert.IsNotNull(testObj.GetStatus().characterName);
        }
          [Test]
        public void StartGameTest()
        {
            testObj.CreateCharacter("Test Character");
            testObj.StartGame();
            Assert.IsNotNull(testObj.GetStatus().characterName);
        }
    }
}