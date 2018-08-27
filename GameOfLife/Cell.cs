using System.Collections.Generic;

namespace GameOfLife
{
    public class Cell
    {
        public long XLocation { get; private set; }
        public long YLocation { get; private set; }

        public Cell(long xLocation, long yLocation)
        {
            XLocation = xLocation;
            YLocation = yLocation;
        }

        public IEnumerable<Cell> Neighbors()
        {
            var neighbors = new List<Cell>();
            var xLocation = XLocation;
            var yLocation = YLocation;

            if (XLocation > long.MinValue && XLocation < long.MaxValue)
            {
                if (YLocation > long.MinValue && YLocation < long.MaxValue)
                {
                    neighbors.Add(new Cell(XLocation - 1, YLocation + 1));
                    neighbors.Add(new Cell(XLocation - 1, YLocation));
                    neighbors.Add(new Cell(XLocation - 1, YLocation - 1));
                    neighbors.Add(new Cell(XLocation, YLocation + 1));
                    neighbors.Add(new Cell(XLocation, YLocation - 1));
                    neighbors.Add(new Cell(XLocation + 1, YLocation + 1));
                    neighbors.Add(new Cell(XLocation + 1, YLocation));
                    neighbors.Add(new Cell(XLocation + 1, YLocation - 1));
                }
                else if (YLocation == long.MinValue)
                {
                    neighbors.Add(new Cell(XLocation - 1, YLocation + 1));
                    neighbors.Add(new Cell(XLocation - 1, YLocation));
                    neighbors.Add(new Cell(XLocation, YLocation + 1));
                    neighbors.Add(new Cell(XLocation + 1, YLocation + 1));
                    neighbors.Add(new Cell(XLocation + 1, YLocation));
                }
                else if (YLocation == long.MaxValue)
                {
                    neighbors.Add(new Cell(XLocation - 1, YLocation));
                    neighbors.Add(new Cell(XLocation - 1, YLocation - 1));
                    neighbors.Add(new Cell(XLocation, YLocation - 1));
                    neighbors.Add(new Cell(XLocation + 1, YLocation));
                    neighbors.Add(new Cell(XLocation + 1, YLocation - 1));
                }
            }
            else if (XLocation == long.MinValue)
            {
                if (YLocation > long.MinValue && YLocation < long.MaxValue)
                {
                    neighbors.Add(new Cell(XLocation, YLocation + 1));
                    neighbors.Add(new Cell(XLocation, YLocation - 1));
                    neighbors.Add(new Cell(XLocation + 1, YLocation + 1));
                    neighbors.Add(new Cell(XLocation + 1, YLocation));
                    neighbors.Add(new Cell(XLocation + 1, YLocation - 1));
                }
                else if (YLocation == long.MinValue)
                {
                    neighbors.Add(new Cell(XLocation, YLocation + 1));
                    neighbors.Add(new Cell(XLocation + 1, YLocation + 1));
                    neighbors.Add(new Cell(XLocation + 1, YLocation));
                }
                else if (YLocation == long.MaxValue)
                {
                    neighbors.Add(new Cell(XLocation, YLocation - 1));
                    neighbors.Add(new Cell(XLocation + 1, YLocation));
                    neighbors.Add(new Cell(XLocation + 1, YLocation - 1));
                }
            }
            else if (XLocation == long.MaxValue)
            {
                if (YLocation > long.MinValue && YLocation < long.MaxValue)
                {
                    neighbors.Add(new Cell(XLocation - 1, YLocation + 1));
                    neighbors.Add(new Cell(XLocation - 1, YLocation));
                    neighbors.Add(new Cell(XLocation - 1, YLocation - 1));
                    neighbors.Add(new Cell(XLocation, YLocation + 1));
                    neighbors.Add(new Cell(XLocation, YLocation - 1));
                }
                else if (YLocation == long.MinValue)
                {
                    neighbors.Add(new Cell(XLocation - 1, YLocation + 1));
                    neighbors.Add(new Cell(XLocation - 1, YLocation));
                    neighbors.Add(new Cell(XLocation, YLocation + 1));
                }
                else if (YLocation == long.MaxValue)
                {
                    neighbors.Add(new Cell(XLocation - 1, YLocation));
                    neighbors.Add(new Cell(XLocation - 1, YLocation - 1));
                    neighbors.Add(new Cell(XLocation, YLocation - 1));
                }
            }

            return neighbors;
        }

        public override string ToString()
        {
            return $"{XLocation.ToString("X")},{YLocation.ToString("X")}";
        }

        public override bool Equals(object obj)
        {
            return (obj is Cell input) && (XLocation == input.XLocation) && (YLocation == input.YLocation);
        }

        public override int GetHashCode()
        {
            var hashCode = 1387378803;
            hashCode = hashCode * -1521134295 + XLocation.GetHashCode();
            hashCode = hashCode * -1521134295 + YLocation.GetHashCode();
            return hashCode;
        }
    }
}