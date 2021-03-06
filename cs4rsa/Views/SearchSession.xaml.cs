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
using cs4rsa.ViewModels;
using System.ComponentModel;

namespace cs4rsa.Views
{
    /// <summary>
    /// Interaction logic for SearchSession.xaml
    /// </summary>
    public partial class SearchSession : UserControl
    {
        DisciplinesViewModel disciplinesViewModel = new DisciplinesViewModel();
        public SearchSession()
        {
            InitializeComponent();
        }

        private void DisciplineComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = disciplinesViewModel;
        }

        private void DisciplineComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            disciplinesViewModel.LoadDisciplineKeyword(DisciplineComboBox.SelectedValue.ToString());
        }

        private void DownloadSubjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
