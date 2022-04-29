using GameStore.commands;
using GameStore.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GameStore.ViewModels
{
    class MainWindowModle
    {
        public event EventHandler EventCloseWindow;
        private BaseCommands changeToRegWindow;
        public BaseCommands ChangeToRegWindow
        {
            get
            {
                return changeToRegWindow ??
                    (changeToRegWindow = new BaseCommands(obj => 
                    {                      
                        WindowsBuilder.ShowRegWindow();
                        Window window = (Window)obj;
                        CloseWindow();
                    }));                   
            }                              
        }

        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
