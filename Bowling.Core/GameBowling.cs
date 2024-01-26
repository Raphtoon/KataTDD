namespace Bowling.Core
{
    public class GameBowling
    {
        // Stockage des lancer
        private int[] _lancer = new int[21];
        // Stockage du score
        private int _score = 2;
        // Stockage du nombre de tours viariable en fonction de strike/spare
        private int _toursMax = 10;
        //suivi du tour en cours (nécessaire pour archiver le score)
        private int _tourActuel = 0;
        // Stockage du nombre de quille
        private int _quilles = 10;

        public int[] Lancer { get => _lancer; set => _lancer = value; }
        public int Score { get => _score; set => _score = value; }
        public int ToursMax { get => _toursMax; set => _toursMax = value; }
        public int TourActuel { get => _tourActuel; set => _tourActuel = value; }
        public int Quilles { get => _quilles; set => _quilles = value; }


        //Fonction score, renvoie le score de tous les tours
        public int GetScore()
        {

            throw new NotImplementedException();
        }


    }


}
