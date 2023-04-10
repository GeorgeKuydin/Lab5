using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IGameProcessPrototype
    {
        IGameProcessPrototype Clone();
        void Display();
    }

    // Concrete prototype class
    class GameProcessPrototype : IGameProcessPrototype
    {
        private string _playerName;
        private int _difficultyLevel;
        private bool _soundEnabled;

        public GameProcessPrototype(string playerName, int difficultyLevel, bool soundEnabled)
        {
            _playerName = playerName;
            _difficultyLevel = difficultyLevel;
            _soundEnabled = soundEnabled;
        }

        public IGameProcessPrototype Clone()
        {
            return new GameProcessPrototype(_playerName, _difficultyLevel, _soundEnabled);
        }

        public void Display()
        {
            Console.WriteLine("Game process:");
            Console.WriteLine("Player name: " + _playerName);
            Console.WriteLine("Difficulty level: " + _difficultyLevel);
            Console.WriteLine("Sound enabled: " + (_soundEnabled ? "Yes" : "No"));
        }
    }

    // Builder interface
   
}
