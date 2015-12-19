using JunkDrawerModel.Database;
using JunkDrawerModel.Interface;
using JunkDrawerModel.Models;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using Junk_Drawer.ViewModels;
namespace Junk_Drawer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
