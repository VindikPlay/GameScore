using GameStore.model;
using GameStore.ModleContext;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GameStore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            WindowsBuilder.ShowMainWindow();
            InitDB();
            base.OnStartup(e);
            
        }

        void InitDB()
        {
            try
            {
                using (StoreDB db = new StoreDB())
                {
                    db.Database.Initialize(false);

                    if (db.User.Count() == 0 && db.Game.Count() == 0)
                    {
                        string imagesPath = @"image\";

                        Game Pacman = new Game(1, "pacman", 0, imagesPath + "game1.jpg");
                        db.Game.Add(Pacman);

                        Game Evil = new Game(2, "Evil Dead", 468, imagesPath + "game2.jpg");
                        db.Game.Add(Evil);

                        Game losTark = new Game(3, "LosTark", 70, imagesPath + "game3.jpg");
                        db.Game.Add(losTark);

                        Game Pokemon = new Game(4, "pokemon", 1000, imagesPath + "game4.jpg");
                        db.Game.Add(Pokemon);

                        Game Mario = new Game(5, "Mario", 40, imagesPath + "game5.jpg");
                        db.Game.Add(Mario);

                        Game Sims4 = new Game(6, "Sims4", 2499, imagesPath + "game6.jpg");
                        db.Game.Add(Sims4);

                        Game PABG = new Game(7, "PABG", (decimal)2182.50, imagesPath + "game7.jpg");
                        db.Game.Add(PABG);

                        User VindiK = new User(1, "VindiK", "VindiKPlaY@gmail.com", "Killmach123");
                        db.User.Add(VindiK);

                        User NaVimma = new User(2, "NaVi/MMA", "NaVi/MMA@gmail.com", "qwerty123");
                        db.User.Add(NaVimma);

                        VindiK.Games.Add(Pacman);
                        NaVimma.Games.Add(PABG); 
                        NaVimma.Games.Add(Pokemon); 
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации БД: {ex.Message}");
            }
        }
    }
}
