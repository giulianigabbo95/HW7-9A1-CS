using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomework
{
    public class ChartManager
    {
        #region Members

        private ggPictureBox ggPictBox;
        private Bitmap bmp;
        private Rectangle viewPort;
        private Graphics G;

        private DistributionManager D;

        private Pen blackPen = new Pen(Color.Black);
        private Pen whitePen = new Pen(Color.White);

        #endregion

        #region Constructor

        public ChartManager(DistributionManager gc, ggPictureBox pictureBox)
        {
            ggPictBox = pictureBox;
            bmp = new Bitmap(ggPictBox.Width, ggPictBox.Height);
            G = Graphics.FromImage(bmp);

            D = gc;
        }

        #endregion
        
        #region Public

        public void DrawChart()
        {
            viewPort = new Rectangle(0, 0, ggPictBox.Width, ggPictBox.Height);
            G.FillRectangle(Brushes.Black, viewPort);

            double minY = 0;
            double maxY = 1;
            double minX = -10;
            double maxX = 10;

            double rangeX = maxX - minX;
            double rangeY = maxY - minY;

            DrawTheoreticalPath(minX, minY, rangeX, rangeY);
            DrawEmpiricalPath(minX, minY, rangeX, rangeY);

            ggPictBox.Image = bmp;

            //var x1 = AdjustX(minX, minX, rangeX);
            //var x2 = AdjustX(maxX, minX, rangeX);
            //var y1 = AdjustY(minY, minY, rangeY);
            //var y2 = AdjustY(viewPort.Height, minY, rangeY);
            //var y = 0.0;

            //var distance = rangeY / 10;
            //for (int i = 0; i < 10; i++)
            //{
            //    y = AdjustY(i * distance, minY, rangeY);
            //    G.DrawLine(whitePen, (float)x1, (float)y, (float)x1 + 10, (float)y);
            //}

            //var middlePoint = rangeY / 2d;
            //y = AdjustY(middlePoint, minY, rangeY);
            //G.DrawLine(whitePen, (float)x1, (float)y, (float)x2, (float)y);
        }

        #endregion

        #region Private

        private void DrawTheoreticalPath(double startX, double startY, double rangeX, double rangeY)
        {
            Pen pen = new Pen(Color.Red);

            var path = D.Paths[0];

            for (int i = 0; i < path.Points.Count - 1; i++)
            {
                var currPoint = D.Paths[0].Points[i];

                double curr_var = currPoint.Y;
                double next_var = path.Points[i + 1].Y;

                RandomPoint p1 = new RandomPoint(curr_var, Density(curr_var));
                RandomPoint p2 = new RandomPoint(next_var, Density(next_var));

                PointF p1Adj = AdjustPoint(p1, startX, startY, rangeX, rangeY);
                PointF p2Adj = AdjustPoint(p2, startX, startY, rangeX, rangeY);

                G.DrawLine(new Pen(Color.Red), p1Adj, p2Adj);
            }
        }

        private void DrawEmpiricalPath(double startX, double startY, double rangeX, double rangeY)
        {
            Pen randomPen = new Pen(Color.Gold);

            float offset = 0;
            var frequency = 0;

            PointF lastPoint = new PointF();

            var theoreticalPath = D.Paths[0];
            var empiricalPath = D.Paths[1];

            for (int i = 0; i < empiricalPath.Points.Count - 1; i++)
            {
                var currPoint = empiricalPath.Points[i];
                var nextPoint = empiricalPath.Points[i + 1];
                frequency = theoreticalPath.Points.Where(x => x.Y >= currPoint.Y && x.Y < nextPoint.Y).Count();

                // draw line
                RandomPoint pCurr = new RandomPoint(currPoint.Y, (frequency + offset) / D.noIterations);
                RandomPoint pNext = new RandomPoint(nextPoint.Y, (frequency + offset) / D.noIterations);

                PointF pCurrAdj = AdjustPoint(pCurr, startX, startY, rangeX, rangeY);
                PointF pNextAdj = AdjustPoint(pNext, startX, startY, rangeX, rangeY);

                // Draw line Horizontal
                G.DrawLine(randomPen, pCurrAdj, pNextAdj);

                // Draw line Vertical
                if (lastPoint.X == 0 && lastPoint.Y == 0)
                    lastPoint = pNextAdj;
                else
                {
                    G.DrawLine(new Pen(Color.Gold), pCurrAdj, lastPoint);
                    lastPoint = pNextAdj;
                }

                offset += frequency;
            }
        }

        private double Density(double z)
        {
            return 1 / (1 + Math.Exp(-0.07056 * z * z * z - 1.5976 * z));
        }

        private List<PointF> GetAdjustedPoints(List<RandomPoint> points, double startX, double startY, double rangeX, double rangeY)
        {
            // Adjusts all points to viewport area
            List<PointF> adjustedPoints = new List<PointF>();

            foreach (RandomPoint point in points)
            {
                var adjPoint = AdjustPoint(point, startX, startY, rangeX, rangeY);
                adjustedPoints.Add(adjPoint);
            }

            return adjustedPoints;
        }

        private PointF AdjustPoint(RandomPoint point, double startX, double startY, double rangeX, double rangeY)
        {
            // Adjusts the point to viewport area
            PointF adjustedPoint = new PointF();

            var X = AdjustX(point.X, startX, rangeX);
            var Y = AdjustY(point.Y, startY, rangeY);
            adjustedPoint = new PointF((float)X, (float)Y);

            return adjustedPoint;
        }

        private double AdjustX(double x, double startX, double rangeX)
        {
            return viewPort.Left + viewPort.Width * ((x - startX) / rangeX);
        }

        private double AdjustY(double y, double startY, double rangeY)
        {
            return viewPort.Top + viewPort.Height - (viewPort.Height * ((y - startY) / rangeY));
        }

        #endregion
    }
}
