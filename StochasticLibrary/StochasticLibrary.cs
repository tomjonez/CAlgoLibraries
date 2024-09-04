using cAlgo.API;
using cAlgo.API.Indicators;

namespace StochasticLibrary
{
    public class Stochastic
    {
        private readonly StochasticOscillator _stochastic;
        private readonly double _overboughtValue;
        private readonly double _oversoldValue;
        private readonly Robot _robot;
        
        public Stochastic(Robot robot, int kPeriod, int dPeriod, int slowing, double overboughtValue, double oversoldValue)
        {
            _robot = robot;
            _stochastic = robot.Indicators.StochasticOscillator(kPeriod, dPeriod, slowing, MovingAverageType.Simple);
            _overboughtValue = overboughtValue;
            _oversoldValue = oversoldValue;
        }
        
        public bool IsStochasticOverbought()
        {
            if (_stochastic.PercentK.Last(1) > _overboughtValue)
            {
                return true;
            }
            return false;
        }

        public bool IsStochasticOversold()
        {
            if (_stochastic.PercentK.Last(1) < _oversoldValue)
            {
                return true;
            }
            return false;
        }

        public double GetPercentK(int position)
        {
            return _stochastic.PercentK.Last(position);
        }
    }
}
