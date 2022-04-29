﻿using GameStore.CustomControlls;
using GameStore.ViewModels;
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
using System.Windows.Shapes;

namespace GameStore.views
{
    /// <summary>
    /// Логика взаимодействия для regWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            WindowBorder windowBorder = new WindowBorder(this);
            windowBorder.SetValue(Grid.RowProperty, 0);
            maingrid.Children.Add(windowBorder);
        }
    }
}
