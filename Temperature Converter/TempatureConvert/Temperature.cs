public class Temperature
{
        private double kelvin;

        public double Kelvin
        {
            get { return kelvin; }
            set { kelvin = value < 0 ? 0 : value; }
        }

        public double Celsius
        {
            get { return Kelvin - 273.15; }
        }

        public double Fahrenheit
        {
            get { return Celsius * 9 / 5 + 32; }
        }
}

