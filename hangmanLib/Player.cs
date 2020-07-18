using System;
namespace hangmanLib
{
    public class Player
    {
        private int _playerScore;

        public Player()
        {

        }

        public int PlayerScore
        {
            get
            {
                return _playerScore;
            }

            set
            {
                _playerScore = value;
            }
        }
    }
}
