using LauncherBackend.Controller;
using LauncherBackend.Modells;
using LauncherBackend.Repository;
using LauncherBackend.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// --------------------------------------------------
//              Launcher - BackendMain
//              Márton Bán (C) 2024
//  
//  This is the entry point of the backend. In this
//  approch some of our data is not go throw all of
//  the layers or skipping some of it. The main reason
//  for this, is becasue there are data's where we
//  doesn't need to do anything, for example GameDTO. 
//---------------------------------------------------

namespace LauncherBackend
{
    public class BackendMain {
        static void Main(string[] args) {
            List<GameDataDTO> list = new List<GameDataDTO>();

            GameController controller = new GameController();
            controller.ConnectToGameDataBase("C:/Server/Databases");

            List<GameDataDTO> games = controller.GetAllGamesFromDatabase();

            foreach (GameDataDTO game in games) {
                Console.WriteLine(game.GameTitle + '\n');
            }
        }
    }
}
