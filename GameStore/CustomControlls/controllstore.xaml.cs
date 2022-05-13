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
    /// <summary>
    /// Логика взаимодействия для controllstore.xaml
    /// </summary>
    public partial class controllstore : UserControl
    {
        Window parent;
        public controllstore(Window parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.MouseDown += UserControll_MouseDown;

            Button closebutton = new Button();
            closebutton.Name = "bClose";
            closebutton.SetValue(Grid.ColumnProperty, 5);
            closebutton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff8d00D2"));
            closebutton.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            closebutton.Content = "X";
            closebutton.VerticalAlignment = VerticalAlignment.Center;
            closebutton.HorizontalAlignment = HorizontalAlignment.Center;
            closebutton.Click += Close_Click;
            maingrid1.Children.Add(closebutton);

            Button hideButton = new Button();
            hideButton.Name = "bHide";
            hideButton.SetValue(Grid.ColumnProperty, 1);
            hideButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff8d00D2"));
            hideButton.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            hideButton.Content = "-";
            hideButton.VerticalAlignment = VerticalAlignment.Center;
            hideButton.HorizontalAlignment = HorizontalAlignment.Center;
            hideButton.Click += Hide_Click;
            maingrid1.Children.Add(hideButton);

            Button maxButton = new Button();
            maxButton.Name = "bmax";
            maxButton.SetValue(Grid.ColumnProperty, 3);
            maxButton.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            maxButton.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            maxButton.Content = "[]";
            maxButton.VerticalAlignment = VerticalAlignment.Center;
            maxButton.HorizontalAlignment = HorizontalAlignment.Center;
            maxButton.Click += Max_Click;
            maingrid1.Children.Add(maxButton);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.parent.Close();
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            this.parent.WindowState = WindowState.Minimized;
        }

        private void Max_Click(object sender, RoutedEventArgs e)
        {
            if (parent.WindowState == WindowState.Maximized)
            {
                parent.WindowState = WindowState.Normal;
            }
            else
            {
                parent.WindowState = WindowState.Maximized;
            }
        }

        private void UserControll_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                parent.DragMove();
        }
    }
}
