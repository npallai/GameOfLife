using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Main : Form
    {
        private Universe _universe;
        private Bitmap _map;
        private long _xOffset = 0;
        private long _yOffset = 0;
        private bool _started = false;

        public Main()
        {
            InitializeComponent();

            _universe = new Universe(StartingCells.GetStartingCells());
            _universe.OnCellIsAlive += Universe_OnCellIsAlive;
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
            var xPixelToSet = e.XLocation - _xOffset;
            var yPixelToSet = e.YLocation - _yOffset;

            if (e.XLocation >= _xOffset + _map.Width || e.XLocation < _xOffset || e.YLocation >= _yOffset + _map.Height || e.YLocation < _yOffset)
            {
                return;
            }

            try
            {
                _map.SetPixel((int)(xPixelToSet), (int)(yPixelToSet), Color.Black);
            }
            catch
            { }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _xOffset--;
                    break;
                case Keys.Right:
                    _xOffset++;
                    break;
                case Keys.Up:
                    _yOffset++;
                    break;
                case Keys.Down:
                    _yOffset--;
                    break;
            }

            picBxMain.Image = _map;
        }

        private void picBxMain_MouseClick(object sender, MouseEventArgs e)
        {
            nextGenTimer.Interval = int.Parse(mTbxInterval.Text);

            if (_started)
            {
                nextGenTimer.Stop();
            }
            else
            {
                nextGenTimer.Start();
            }

            _started = !_started;
            mTbxInterval.Enabled = !mTbxInterval.Enabled;
        }
    }
}