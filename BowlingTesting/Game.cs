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
        public void When_GetScore_Returns_Exception()
        {
            //Arrange 
            GameBowling game = new();

            //Act

            Assert.Throws<NotImplementedException>(() => game.GetScore());
        }
    }
}
