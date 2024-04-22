using LauncherBackend.Database;
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

            GameDataService gameDataService = new GameDataService("C:/FTP");

            List<GameDTO> list = new List<GameDTO>();
            list = gameDataService.GetAllGames();

            foreach (GameDTO game in list) {
                Debug.WriteLine(game.GameTitle + "\n");  
            }

            GameDTO game3 = new GameDTO{ GameTitle = "My Memory of Us",
                                        Description = "One of the best game ever",
                                        Developer = "Tets",
                                        Publisher = "Test",
                                        IconPath = "asd",
                                        ThumbnailPath = "asd"
            };

            gameDataService.AddGame(game3);
            Debug.WriteLine("---------------------------------------");
            foreach (GameDTO game in list) {
                Debug.WriteLine(game.GameTitle + "\n");
            }
        }
    }
}
