using Xunit;
using RegnumMedievalis.CoreLoop;

namespace RegnumMedievalis.CoreLoop.Tests
{
    public class MedievalCoreLoopTests
    {
        [Fact]
        public void Treasury_Should_Change_After_Turn()
        {
            var game = new MedievalCoreLoop(seed: 42);
            var initialTreasury = game.Treasury;

            game.RunTurn();

            Assert.NotEqual(initialTreasury, game.Treasury);
        }

        [Fact]
        public void Stability_Should_Not_Be_Negative_After_Many_Turns()
        {
            var game = new MedievalCoreLoop(seed: 1337);
            for (int i = 0; i < 100; i++) game.RunTurn();
            Assert.True(game.Stability >= 0, "Stability should never drop below zero.");
        }
    }
}
