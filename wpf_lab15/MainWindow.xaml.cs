﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_lab15
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = File.Open("1.xaml", FileMode.Open))
            {
                docViewer.Document = XamlReader.Load(fs) as FlowDocument;
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = File.Open("1.xaml", FileMode.Create))
            {
                XamlWriter.Save(docViewer.Document, fs);
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            docViewer.ClearValue(FlowDocumentScrollViewer.DocumentProperty);
        }
    }
}
