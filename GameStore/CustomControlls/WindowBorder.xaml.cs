using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameStore.CustomControlls
{
    public partial class WindowBorder : UserControl
    {
        Window parent;
        public WindowBorder(Window parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.MouseDown += UserControll_MouseDown;

            Button closebutton = new Button();
            closebutton.Name = "bClose";
            closebutton.SetValue(Grid.ColumnProperty, 2);
            closebutton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff8d00D2"));
            closebutton.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            closebutton.Content = "X";
            closebutton.VerticalAlignment = VerticalAlignment.Center;
            closebutton.HorizontalAlignment = HorizontalAlignment.Center;
            closebutton.Click += Close_Click;
            maingrid.Children.Add(closebutton);

            Button hideButton = new Button();
            hideButton.Name = "bHide";
            hideButton.SetValue(Grid.ColumnProperty, 1);
            hideButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff8d00D2"));
            hideButton.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            hideButton.Content = "-";
            hideButton.VerticalAlignment = VerticalAlignment.Center;
            hideButton.HorizontalAlignment = HorizontalAlignment.Center;
            hideButton.Click += Hide_Click;
            maingrid.Children.Add(hideButton);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.parent.Close();
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            this.parent.WindowState = WindowState.Minimized;
        }

        private void UserControll_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                parent.DragMove();
        }
    }
}
