namespace homework4
{
    public class Converter
    {
        private const double Tjs = 1;
        private readonly double _usd;
        private readonly double _eur;
        private readonly double _rub;

        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public double TjsToUsd(double amount)
        {
            return amount * _usd / Tjs;
        }

        public double TjsToEur(double amount)
        {
            return amount * _eur / Tjs;
        }

        public double TjsToRub(double amount)
        {
            return amount * _rub / Tjs;
        }

        public double UsdToTjs(double amount)
        {
            return Tjs * amount / _usd;
        }

        public double EurToTjs(double amount)
        {
            return Tjs * amount / _eur;
        }

        public double RubToTjs(double amount)
        {
            return Tjs * amount / _rub;
        }
    }
}