using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace SemiCircleApp
{
    public class SemiCircle
    {
        private Ellipse ellipse;
        private Rectangle rectangle;

        public SemiCircle(double radius, Point position)
        {
            ellipse = new Ellipse
            {
                Width = 2 * radius,
                Height = 2 * radius,
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            Canvas.SetLeft(ellipse, position.X - radius);
            Canvas.SetTop(ellipse, position.Y - radius);

            rectangle = new Rectangle
            {
                Width = 2 * radius,
                Height = radius,
                Fill = Brushes.White,
                StrokeThickness = 0
            };

            Canvas.SetLeft(rectangle, position.X - radius);
            Canvas.SetTop(rectangle, position.Y);
        }

        public void Show(UIElementCollection uiElementCollection)
        {
            if (!uiElementCollection.Contains(ellipse))
            {
                uiElementCollection.Add(ellipse);
            }
            if (!uiElementCollection.Contains(rectangle))
            {
                uiElementCollection.Add(rectangle);
            }
        }

        public void Hide(UIElementCollection uiElementCollection)
        {
            if (uiElementCollection.Contains(ellipse))
            {
                uiElementCollection.Remove(ellipse);
            }
            if (uiElementCollection.Contains(rectangle))
            {
                uiElementCollection.Remove(rectangle);
            }
        }

        public void MoveXY(double x, double y)
        {
            double radius = ellipse.Width / 2;

            Canvas.SetLeft(ellipse, x - radius);
            Canvas.SetTop(ellipse, y - radius);

            Canvas.SetLeft(rectangle, x - radius);
            Canvas.SetTop(rectangle, y);
        }

        public Point Position
        {
            get
            {
                double x = Canvas.GetLeft(ellipse) + ellipse.Width / 2;
                double y = Canvas.GetTop(ellipse) + ellipse.Height / 2;
                return new Point(x, y);
            }
        }
    }
}
