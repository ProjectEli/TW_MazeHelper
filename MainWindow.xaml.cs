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

namespace TW_MazeHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Topmost = true;
            putCardImage.Source = new BitmapImage(new Uri("pack://application:,,,/TW_ClubMaze.png"));
        }

        private void VisibilityToggle(object sender, RoutedEventArgs e)
        {
            if (putCardImage.Visibility == Visibility.Visible) { putCardImage.Visibility = Visibility.Collapsed; }
            else { putCardImage.Visibility = Visibility.Visible; }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
