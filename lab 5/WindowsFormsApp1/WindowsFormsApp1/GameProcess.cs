using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    interface IGameProcessBuilder
    {
        void SetPlayerName(string playerName);
        void SetDifficultyLevel(int difficultyLevel);
        void SetSoundEnabled(bool soundEnabled);
        IGameProcessPrototype GetGameProcessPrototype();
    }

    // Concrete builder class
    class GameProcessBuilder : IGameProcessBuilder
    {
        private string _playerName;
        private int _difficultyLevel;
        private bool _soundEnabled;

        public void SetPlayerName(string playerName)
        {
            _playerName = playerName;
        }

        public void SetDifficultyLevel(int difficultyLevel)
        {
            _difficultyLevel = difficultyLevel;
        }

        public void SetSoundEnabled(bool soundEnabled)
        {
            _soundEnabled = soundEnabled;
        }

        public IGameProcessPrototype GetGameProcessPrototype()
        {
            return new GameProcessPrototype(_playerName, _difficultyLevel, _soundEnabled);
        }
    }

    // Director class
    class GameProcessDirector
    {
        private IGameProcessBuilder _builder;

        public GameProcessDirector(IGameProcessBuilder builder)
        {
            _builder = builder;
        }

        public void Construct(string playerName, int difficultyLevel, bool soundEnabled)
        {
            _builder.SetPlayerName(playerName);
            _builder.SetDifficultyLevel(difficultyLevel);
            _builder.SetSoundEnabled(soundEnabled);
        }
    }
}
