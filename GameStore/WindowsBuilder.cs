using GameStore.ViewModels;
using GameStore.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class WindowsBuilder
    {
        public static void ShowMainWindow()
        {
            var window = new MainWindow();
            var viewModel = new MainWindowModle();
            window.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); };
            window.Show();
        }

        public static void ShowRegWindow()
        {
            var window = new RegWindow();
            var viewModel = new RegWindowmodle();
            window.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); };
            window.Show();
        }

        public static void ShowStoreWindow()
        {
            StoreWindow store = new StoreWindow();
            var viewModel = new StoreWindowModle();
            store.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { store.Close(); };
            store.Show();
        }
    }
}
