using Design_Patterns___DOOM_Game;
using NUnit.Framework;


namespace Design_Patterns___DOOM_Game.Tests.Unit
{
    [TestFixture]
    public class WeaponTests
    {
        [Test]
        public void Chainsaw_PickupMessage()
        {           
            Weapon chainsaw = new Chainsaw();
            string expectedOutput = "Chainsaw found!";
            StringWriter consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
          
            chainsaw.Use();
            string actualOutput = consoleOutput.ToString().Trim();

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}