﻿using System;
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

namespace ToDoApp.Views
{
    /// <summary>
    /// Interaction logic for NewTodoView.xaml
    /// </summary>
    public partial class NewTodoView : UserControl
    {
        public NewTodoView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Item added", "Add Item", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
