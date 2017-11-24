﻿using AIC.HistoryDataPage.ViewModels;
using MahApps.Metro.Controls;
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

namespace AIC.HistoryDataPage.Views
{
    /// <summary>
    /// HistoryEventAlarmTrendWin.xaml 的交互逻辑
    /// </summary>
    public partial class HistoryEventAlarmTrendView : MetroWindow
    {
        public HistoryEventAlarmTrendView()
        {
            InitializeComponent();
            Loaded += HistoryDataDiagramView_Loaded;
            SizeChanged += HistoryEventAlarmTrendView_SizeChanged;          
        }

        private void HistoryEventAlarmTrendView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            VerticalAlignButtonClick(null, null);
        }

        public HistoryEventAlarmTrendViewModel ViewModel
        {
            get { return DataContext as HistoryEventAlarmTrendViewModel; }
            set { this.DataContext = value; }
        }

        private void HistoryDataDiagramView_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= HistoryDataDiagramView_Loaded;
            VerticalAlignButtonClick(null, null);
        }

        private void VerticalAlignButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.ItemWidth = listBox.ActualWidth - 20;
            ViewModel.ItemHeight = listBox.ActualHeight / ViewModel.HistoricalDatas.Where(o => o.IsVisible == true).Count() - 5;
        }
    }
}
