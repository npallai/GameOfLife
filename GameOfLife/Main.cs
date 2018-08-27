using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    //First pass at a GUI. First iteration - display positive space only and bound by the picture box size.
    //Next step is to make the picture box act as a sliding window over the entire 64bit space.
    public partial class Main : Form
    {
        private Universe _universe;
        private Bitmap _map;

        public Main()
        {
            InitializeComponent();

            _universe = new Universe(GetTestingCells());
            _universe.OnCellIsAlive += Universe_OnCellIsAlive;
            //_map = new Bitmap(picBxMain.Width, picBxMain.Height);
        }

        private List<Cell> GetTestingCells()
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

        private void NextGenTimer_Tick(object sender, EventArgs e)
        {
            _map = new Bitmap(picBxMain.Width, picBxMain.Height);
            _universe.Tick();
            lblAge.Text = $"Age: {_universe.Age}";

            foreach (var cell in _universe._currentLiveGen)
            {
                if (cell.Value.XLocation <= 0 || cell.Value.XLocation >= picBxMain.Width || cell.Value.YLocation <= 0 || cell.Value.YLocation >= picBxMain.Height)
                    continue;
            }

            picBxMain.Image = _map;
        }

        private void Universe_OnCellIsAlive(object sender, CellEventArgs e)
        {
            if (e.XLocation > _map.Width || e.XLocation < 0 || e.YLocation > _map.Height || e.YLocation < 0)
            {
                return;
            }

            _map.SetPixel(unchecked((int)e.XLocation), unchecked((int)e.YLocation), Color.Black);
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            nextGenTimer.Interval = int.Parse(mTbxInterval.Text);
            nextGenTimer.Start();
            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            nextGenTimer.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
