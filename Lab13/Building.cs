using System;

namespace Lab13
{
    internal class Building
    {
        string address;
        double length;
        double width;
        double height;
        

        double Length 
        {
            get
            {
                return length;
            }
            set
            {
                if (value>100000)
                    length = 100000;
                else
                    length = value;
            }
        }        
        double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value>100000)
                    width = 100000;
                else
                    width = value;
            }
        }
        double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 100000)
                    height = 100000;
                else
                    height = value;
            }
        }
        public Building(string address, double length, double width, double height)
        {
            this.address = address;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        { 
            return $"{address} {length} {width} {height}"; 
        }
    }

}