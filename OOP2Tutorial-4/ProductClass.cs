namespace OOP2Tutorial_4
{
    public class Product
    {
        private string _name;
        private double _price;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public override string ToString()
        {
            return _name + " (" + _price + ")";
        }

        public bool ValidatePrice()
        {
            if (Price < 0 || Price > 9999)
            {
                return false;
            }
            return true;
        }
    }
}