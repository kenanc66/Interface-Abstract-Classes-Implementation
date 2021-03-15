using SaveSystem.Abstract;
using SaveSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveSystem.Concrete
{
    public class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("game "+game.GameName+" added to the store");
        }
        public void DeleteGame(Game game)
        {
            Console.WriteLine("game " + game.GameName + " deleted from the store");
        }
        
    }
}
