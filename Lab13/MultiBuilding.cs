namespace Lab13
{
    internal class MultiBuilding : Building

    {
        int floors;

        public MultiBuilding(string address, double length, double width, double height, int floors)
            : base(address, length, width, height)
        {
            this.floors = floors;
        }
        int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                if (value > 80)
                    floors = 80;
                else
                    floors = value;
            }
        }
        public string Print()
        {
            string result = base.Print();
            result += $" {floors}";
            return result;
        }
    }
}
