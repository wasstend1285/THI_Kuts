namespace LAB3_THI
{
    public class AbstractCandies
    {
        private string _name;
        private double _price;
        private double _weight;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price 
        {
            get { return _price; }
            set { _price = value; }
        }    

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

    }

}