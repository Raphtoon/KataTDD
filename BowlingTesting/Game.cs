using Bowling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingTesting
{
    // Une qui vérifie si c'est un strike
    // Une qui vérifie si c'est un spare
    // Une qui vérifie si c'est un si elle ne sont pas toutes tombées
    // Une qui vérifie si c'est un si il en a touché 1 ou + mais < que toutes
    // Une qui vérifie si c'est un 

    [TestFixture]

    public class Game
    {

        [Test]
        public void When_GetScore_And_ActualTurn_IsHigher_Than_TurnMax_Returns_Exception()
        {
            GameBowling game = new();
            Assert.Throws<NotImplementedException>(() => game.GetScore());
        }

        [Test]
        public void When_GetScore_Returns_Score()
        {
            GameBowling game = new();
            game.TourActuel = 22;
            var result = game.GetScore();
            Assert.AreEqual(20, result);
        }



    }
}
