using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics;

namespace OTC
{
    class OptionsCalculator
    {
        OptionsCalculator()
        {
            this.normDist = new Accord.Statistics.Distributions.Univariate.NormalDistribution(0, 1);
        }

        OptionsCalculator(double sigma, double r, double yield)
        {
            this.sigma = sigma;
            this.r = r;
            this.yield = yield;
        }

        static private double Ln(double x)
        {
            return Math.Log(x, Math.E);
        }

        static private double D1(double S, double K, double T, double sigma, double r)
        {
            return (Ln(S / K) + (r + sigma * sigma / 2) * T) / (sigma * Math.Sqrt(T));
        }

        static private double D2(double S, double K, double T, double sigma, double r)
        {
            return (Ln(S / K) + (r - sigma * sigma / 2) * T) / (sigma * Math.Sqrt(T));
        }

       static private decimal GetBlsCallPrice(double S, double K, double T, double sigma, double r)
        {
            Accord.Statistics.Distributions.Univariate.NormalDistribution normDist = new Accord.Statistics.Distributions.Univariate.NormalDistribution();
            return decimal.Ceiling((decimal)(S * normDist.DistributionFunction(D1(S, K, T, sigma, r)) - K * Math.Exp(-r * T) * normDist.DistributionFunction(D2(S, K, T, sigma, r)))*100m)/100m;
            //return S * normDist.DistributionFunction(D1(S, K, T, sigma, r)) - K * Math.Exp(-r * T) * normDist.DistributionFunction(D2(S, K, T, sigma, r));
        }

        static private decimal GetBlsPutPrice(double S, double K, double T, double sigma, double r)
        {
            Accord.Statistics.Distributions.Univariate.NormalDistribution normDist = new Accord.Statistics.Distributions.Univariate.NormalDistribution();
            return decimal.Ceiling((decimal)(-S * normDist.DistributionFunction(-D1(S, K, T, sigma, r)) + K * Math.Exp(-r * T) * normDist.DistributionFunction(-D2(S, K, T, sigma, r)))*100m)/100m;
            //return -S * normDist.DistributionFunction(-D1(S, K, T, sigma, r)) + K * Math.Exp(-r * T) * normDist.DistributionFunction(-D2(S, K, T, sigma, r));
        }

        static public decimal GetBlsPrice(double S, double K, double T, double sigma, double r, char type)
        {
            return type == 'c' ? GetBlsCallPrice(S, K, T, sigma, r) : GetBlsPutPrice(S, K, T, sigma, r);
        }

        static public double GetBlsDelta(double S, double K, double T, double sigma, double r, char type)
        {
            Accord.Statistics.Distributions.Univariate.NormalDistribution normDist = new Accord.Statistics.Distributions.Univariate.NormalDistribution();
            return type == 'c'? (normDist.DistributionFunction(D1(S, K, T, sigma, r))) : (normDist.DistributionFunction(D1(S, K, T, sigma, r))-1);

        }

        private double D1(double S, double K, double T)
        {
            return (Ln(S / K) + ( sigma * sigma / 2)*T)/(sigma* Math.Sqrt(T));
        }

        private double D2(double S, double K, double T)
        {
            return (Ln(S / K) + ( - sigma * sigma / 2) * T) / (sigma * Math.Sqrt(T));
        }

        private decimal GetBlsCallPrice(double S, double K, double T)
        {
            return (decimal)(S * normDist.DistributionFunction(D1(S, K, T)) - K * Math.Exp(-this.r * T) * normDist.DistributionFunction(D2(S, K, T)));
        }

        private decimal GetBlsPutPrice(double S, double K, double T)
        {
            return (decimal)(-S * normDist.DistributionFunction(-D1(S, K, T)) + K * Math.Exp(-this.r * T) * normDist.DistributionFunction(-D2(S, K, T)));
        }



        private double sigma;
        private double r;
        private double yield;
        private Accord.Statistics.Distributions.Univariate.NormalDistribution normDist;

    }
}
