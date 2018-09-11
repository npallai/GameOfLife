namespace GameOfLife
{
    public class CellEventArgs
    {
        public long XLocation { get; set; }
        public long YLocation { get; set; }

        public CellEventArgs(long xLocation, long yLocation)
        {
            XLocation = xLocation;
            YLocation = yLocation;
        }
    }
}