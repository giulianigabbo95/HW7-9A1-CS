using System;
using System.Linq;
using System.Collections.Generic;

namespace MyHomework
{
    public class RandomPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public RandomPoint()
        {
            X = 0;
            Y = 0;
        }

        public RandomPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class RandomPath
    {
        public List<RandomPoint> Points { get; set; }

        public RandomPath()
        {
            Points = new List<RandomPoint>();
        }
    }

    public class DistributionManager
    {
        #region MEMBERS

        public RandomPath[] Paths { get; set; }
        public int noPoints { get; set; }
        public int noIterations { get; set; }

        private Random Rnd = new Random();

        private readonly double sigma = 1d;
        private readonly double mean = 50d;

        #endregion

        #region CONSTRUCTOR

        public DistributionManager(int nbTrials, int nbIterations)
        {
            noPoints = nbTrials;
            noIterations = nbIterations;

            this.Paths = new RandomPath[2];
            Paths[0] = CreateTheoreticalDistribution(nbTrials);
        }

        #endregion

        #region PUBLIC

        public RandomPath CreateEmpiricalDistribution(int n)
        {
            var path = new RandomPath();
            List<double> means = new List<double>();
            double sample_mean = 0;

            for (int i = 0; i < noIterations; i++)
            {
                for (double c = 0; c < n; c++)
                {
                    var rnd = Rnd.NextDouble();
                    var p = rnd <= 0.5 ? 1 : 0;
                    if (p == 1)
                        sample_mean += (p - 0.5);
                }

                means.Add(sample_mean);
            }

            means.Sort();

            for (int i = 0; i < means.Count; i++)
            {
                path.Points.Add(new RandomPoint() { X = i + 1, Y = means[i] });
            }

            foreach (var p in Paths[0].Points)
            {
                path.Points.Add(new RandomPoint() { X = p.X + Paths[0].Points.Count, Y = p.Y });
            }

            return path;
        }

        #endregion

        #region PRIVATE

        private RandomPath CreateTheoreticalDistribution(int n)
        {
            var path = new RandomPath();
            List<double> means = new List<double>();
            double cum_mean = 0;

            for (int i = 0; i < noIterations; i++)
            {
                for (double c = 0; c < n; c++)
                {
                    double x = Rnd.Next(1, 100);
                    cum_mean += (x - cum_mean) / (c + 1);
                }

                cum_mean = (cum_mean - mean) / Math.Sqrt(sigma);
                means.Add(cum_mean);
            }

            means.Sort();

            for (int i = 0; i < means.Count; i++)
            {
                path.Points.Add(new RandomPoint() { X = i + 1, Y = means[i] });
            }

            return path;
        }

        #endregion
    }
}
