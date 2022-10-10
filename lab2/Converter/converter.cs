using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public enum Currency
    {
        USD,
        EUR,
        YEN
    }

    public class Converter
    {
        private Dictionary<Currency, float> _rate;

        public Converter(float usd, float eur, float yen)
        {
            _rate = new Dictionary<Currency, float>();
            _rate.Add(Currency.USD, usd);
            _rate.Add(Currency.YEN, yen);
            _rate.Add(Currency.EUR, eur);
        }

        public float ToHryvnia(float value, Currency currency)
        {
            float cur = _rate.GetValueOrDefault(currency);
            return value / cur;
        }

        public float FromHryvnia(float value, Currency currency)
        {
            float cur = _rate.GetValueOrDefault(currency);
            return value * cur;
        }
    }
}