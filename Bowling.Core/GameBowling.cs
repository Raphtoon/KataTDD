namespace Bowling.Core
{
    public class GameBowling
    {
        // Stockage des lancer
        private List<int> _lancer = new();
        // Stockage du score
        private int _score = 20;
        // Stockage du nombre de tours viariable en fonction de strike/spare
        private int _toursMax = 10;
        //suivi du tour en cours (nécessaire pour archiver le score)
        private int _tourActuel = 0;
        // Stockage du nombre de quille
        private int _quilles = 10;

        public List<int> Lancer { get => _lancer; set => _lancer = value; }
        public int Score { get => _score; set => _score = value; }
        public int ToursMax { get => _toursMax; set => _toursMax = value; }
        public int TourActuel { get => _tourActuel; set => _tourActuel = value; }
        public int Quilles { get => _quilles; set => _quilles = value; }


        //Fonction score, renvoie le score de tous les tours
        public int GetScore()
        {
            if(TourActuel >= ToursMax) 
                return Score;
            else
            throw new NotImplementedException();
        }

        // verifier si on a touché une quille, l'ajouter au score
        public void HitPin(int nbPinHit)
        {
            if (nbPinHit < 0)
            {
                Lancer.Add(Lancer.Count + 1);
                Score += nbPinHit;
            }
            else
            {
                throw new NotImplementedException();
                Lancer.Add(Lancer.Count + 1);
            }
        }
    }
}
