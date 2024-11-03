namespace LaConga.GameLogic
{
    public class Game
    {
        public List<Player> Players { get; private set; }
        private Deck Deck;
        private int CurrentPlayerIndex;
        public int MaxPlayers { get; private set; }
        private Card LastPlayedCard;
        private bool IsActive;
        private Dictionary<string, List<int>> ScoreBoard;

        public Game(int maxPlayers)
        {
            Deck = new Deck();
            Players = new List<Player>();
            MaxPlayers = maxPlayers;
            CurrentPlayerIndex = 0;
            LastPlayedCard = null;
            ScoreBoard = new Dictionary<string, List<int>>();
        }
    }
}
