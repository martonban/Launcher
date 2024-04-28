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

            GameDataDTO game1 = new GameDataDTO {
                Id = 1,
                GameTitle = "Classy Clash",
                Description = "A Zelda like adventure game powered by the Nebula Pax Engine",
                Developer = "Marton Ban",
                Publisher = "Emfis Games",
                FTPFolderPath = "/Games",
                FileName = "/Classy_Clash_v1.0.0.zip",
                IconPath = "/Media/Games/ClassyClash/icon.png",
                ThumbnailPath = "/Media/Games/ClassyClash/cover.png"
            };

            GameDataDTO game2 = new GameDataDTO {
                Id = 2,
                GameTitle = "The Third Wish",
                Description = "The Third Wish is a sci-fi point and click adventure about a family and fate and consequence.",
                Developer = "George Broussard",
                Publisher = "George Broussard",
                FTPFolderPath = "/Games",
                FileName = "/TheThirdWish_v14.zip",
                IconPath = "/Media/Games/TheThirdWish/icon.png",
                ThumbnailPath = "/Media/Games/TheThirdWish/cover.png"
            };

            controller.InsertGameToTheDatabase(game1);
            controller.InsertGameToTheDatabase(game2);

        }
    }
}
