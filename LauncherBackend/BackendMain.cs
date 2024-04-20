using LauncherBackend.DTOs;
using LauncherBackend.Repository;
using System;
using System.Collections.Generic;
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

namespace LauncherBackend {
    public class BackendMain {
        static void Main(string[] args) {
            LauncherRepository launcherRepository = new LauncherRepository();
            launcherRepository.ConnectGameDatabase("C:/FTP");



            GameDTO game1 = new GameDTO{ GameTitle = "No Man's Sky",
                                        Description = "One of the best game ever",
                                        Developer = "HelloGames",
                                        Publisher = "HelloGames",
                                        IconPath = "asd",
                                        ThumbnailPath = "asd"
            };

            GameDTO game2 = new GameDTO {
                GameTitle = "Fallout 76",
                Description = "One of the best worst game ever",
                Developer = "Beteshda Softwares",
                Publisher = "Beteshda Softwares",
                IconPath = "asd",
                ThumbnailPath = "asd"
            };

            List<GameDTO> gameDTOs = new List<GameDTO>();
            gameDTOs = launcherRepository.GetAllGames();

        }
    }
}
