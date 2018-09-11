using System.Collections.Generic;

namespace GameOfLife
{
    public class StartingCells
    {
        public static List<Cell> GetStartingCells()
        {
            List<Cell> livingCells = new List<Cell>
            {
                new Cell(100, 100), //Block
                new Cell(101, 100),
                new Cell(10, 101),
                new Cell(101, 101),
                new Cell(200, 200), //Blinker
                new Cell(200, 201),
                new Cell(200, 202),
                new Cell(300, 300), //Glider
                new Cell(301, 300),
                new Cell(302, 300),
                new Cell(302, 299),
                new Cell(301, 298),
                new Cell(400, 300), //Glider
                new Cell(401, 300),
                new Cell(402, 300),
                new Cell(402, 299),
                new Cell(401, 298),
                new Cell(500, 300), //Glider
                new Cell(501, 300),
                new Cell(502, 300),
                new Cell(502, 299),
                new Cell(501, 298),
                new Cell(-200, -100), //Glider
                new Cell(-199, -100),
                new Cell(-198, -100),
                new Cell(-198, -101),
                new Cell(-199, -102),
                new Cell(600, 200), //Pentadecathlon
                new Cell(601, 200),
                new Cell(602, 200),
                new Cell(601, 201),
                new Cell(601, 202),
                new Cell(600, 203),
                new Cell(601, 203),
                new Cell(602, 203),
                new Cell(600, 205),
                new Cell(601, 205),
                new Cell(602, 205),
                new Cell(600, 206),
                new Cell(601, 206),
                new Cell(602, 206),
                new Cell(600, 208),
                new Cell(601, 208),
                new Cell(602, 208),
                new Cell(601, 209),
                new Cell(601, 210),
                new Cell(600, 211),
                new Cell(601, 211),
                new Cell(602, 211),
                new Cell(300, 200), //Pentadecathlon
                new Cell(301, 200),
                new Cell(302, 200),
                new Cell(301, 201),
                new Cell(301, 202),
                new Cell(300, 203),
                new Cell(301, 203),
                new Cell(302, 203),
                new Cell(300, 205),
                new Cell(301, 205),
                new Cell(302, 205),
                new Cell(300, 206),
                new Cell(301, 206),
                new Cell(302, 206),
                new Cell(300, 208),
                new Cell(301, 208),
                new Cell(302, 208),
                new Cell(301, 209),
                new Cell(301, 210),
                new Cell(300, 211),
                new Cell(301, 211)
            };

            return livingCells;
        }
    }
}