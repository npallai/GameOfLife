namespace GameOfLife
{
    public class Position
    {
        public long XMinCoordinate { get; private set; }
        public long XMaxCoordinate { get; private set; }
        public long YMinCoordinate { get; private set; }
        public long YMaxCoordinate { get; private set; }

        public Position(long xMin, long xMax, long yMin, long yMax)
        {
            XMinCoordinate = xMin;
            XMaxCoordinate = xMax;
            YMinCoordinate = yMin;
            YMaxCoordinate = yMax;
        }
    }
}