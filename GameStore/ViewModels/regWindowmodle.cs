using GameStore.commands;
using GameStore.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameStore.ViewModels
{
    class RegWindowmodle : INotifyPropertyChanged
    {
        public event EventHandler EventCloseWindow;
        public event PropertyChangedEventHandler PropertyChanged;

        string newUserLogin;
        string newUserEmail;

        public string NewUserLogin
        {
            get {return newUserLogin; }
            set
            {
                newUserLogin = value;
                /*OnPropertyChanged("NewUserLogin");*/
            }
        }

        public string NewUserEmail
        {
            get {return newUserEmail; }
            set
            {
                newUserEmail = value;
                /*OnPropertyChanged("NewUserEmail");*/
            }
        }

        private BaseCommands changeToMainWindow;
        public BaseCommands ChangeToMainWindow
        {
            get
            {
                return changeToMainWindow ??
                    (changeToMainWindow = new BaseCommands(obj => 
                    {                      
                        WindowsBuilder.ShowMainWindow();
                        Window window = (Window)obj;
                        CloseWindow();
                    }));                   
            }    
            
        }

        private BaseCommands addNewUser;
        /*public BaseCommands AddNewUser
        {
            get
            {

            }
        }*/
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
