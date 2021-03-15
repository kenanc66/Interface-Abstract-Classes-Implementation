using SaveSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveSystem.Abstract
{
    public interface IGameService
    {
        void AddGame(Game game);
        void DeleteGame(Game game);
    }
}
