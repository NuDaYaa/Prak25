using System;
using System.Windows;
using System.Windows.Controls;

namespace SemiCircleApp
{
    public partial class MainWindow : Window
    {
        private SemiCircle semiCircle;

        public MainWindow()
        {
            InitializeComponent();

            semiCircle = new SemiCircle(50, new Point(100, 100));
            semiCircle.Show(MyCanvas.Children);
        }

        private void MoveUp_Click(object sender, RoutedEventArgs e)
        {
            semiCircle.MoveXY(semiCircle.Position.X, semiCircle.Position.Y - 10);
        }

        private void MoveDown_Click(object sender, RoutedEventArgs e)
        {
            semiCircle.MoveXY(semiCircle.Position.X, semiCircle.Position.Y + 10);
        }

        private void MoveLeft_Click(object sender, RoutedEventArgs e)
        {
            semiCircle.MoveXY(semiCircle.Position.X - 10, semiCircle.Position.Y);
        }

        private void MoveRight_Click(object sender, RoutedEventArgs e)
        {
            semiCircle.MoveXY(semiCircle.Position.X + 10, semiCircle.Position.Y);
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            semiCircle.Show(MyCanvas.Children);
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            semiCircle.Hide(MyCanvas.Children);
        }

        private void MoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(XCoordinateTextBox.Text, out double x) && double.TryParse(YCoordinateTextBox.Text, out double y))
            {
                semiCircle.MoveXY(x, y);
            }
            else
            {
                MessageBox.Show("Please enter valid coordinates.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
