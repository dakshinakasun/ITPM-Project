namespace itmp
{
    public class Register
    {
        public string Location { get; set; }

        public int VS1 { get; set; }
        public int VS2 { get; set; }
        public int VS3 { get; set; }
        public int VS4 { get; set; }
        public int VS5 { get; set; }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

    }
}