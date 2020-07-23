using System;
namespace hangmanLib
{
    public class Player
    {
        private int _playerScore;
        private int _playerAttempts;

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

        public int PlayerAttempts
        {
            get
            {
                return _playerAttempts;
            }

            set
            {
                _playerAttempts = value;
            }
        }

    }
}
