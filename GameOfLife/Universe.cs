using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    public class Universe
    {
        public Dictionary<string, Cell> _currentLiveGen { get; private set; }
        private Dictionary<string, Cell> _nextLiveGen { get; set; }
        public long Age { get; private set; }
        public event EventHandler<CellEventArgs> OnCellIsAlive;

        public Universe(List<Cell> startingCells)
        {
            _currentLiveGen = new Dictionary<string, Cell>();
            _nextLiveGen = new Dictionary<string, Cell>();
            AddCells(startingCells);
        }

        public void AddCells(List<Cell> cells)
        {
            foreach (var cell in cells)
            {
                _currentLiveGen.Add(cell.ToString(), cell);
            }
        }

        public void Tick()
        {
            CalculateNextGen();
            Age++;
        }

        private void CalculateNextGen()
        {
            foreach (var cell in _currentLiveGen)
            {
                CalculateCellNextGen(cell);
            }

            _currentLiveGen = new Dictionary<string, Cell>(_nextLiveGen);
            _nextLiveGen.Clear();
        }

        private void CalculateCellNextGen(KeyValuePair<string, Cell> cell)
        {
            if (CellStaysAlive(cell.Value))
            {
                if (!_nextLiveGen.ContainsKey(cell.Key))
                {
                    _nextLiveGen.Add(cell.Key, cell.Value);
                    OnCellIsAlive(this, new CellEventArgs(cell.Value.XLocation, cell.Value.YLocation));
                }
            }

            SpawnNewCells(cell.Value);
        }

        private void SpawnNewCells(Cell liveCell)
        {
            var neighbors = new List<Cell>();
            var xLocation = liveCell.XLocation;
            var yLocation = liveCell.YLocation;

            liveCell.Neighbors().ToList().ForEach(BirthNewCell);
        }

        private bool CellStaysAlive(Cell cell)
        {
            var numOfLiveNeighbors = CountAliveNeighbors(cell);

            if (numOfLiveNeighbors < 2 || numOfLiveNeighbors > 3)
            {
                return false;
            }

            return true;
        }

        private void BirthNewCell(Cell cell)
        {
            if (_nextLiveGen.ContainsKey(cell.ToString()))
                return;

            var numOfLiveNeighbors = CountAliveNeighbors(cell);

            if (numOfLiveNeighbors == 3)
            {
                _nextLiveGen.Add(cell.ToString(), cell);
                OnCellIsAlive(this, new CellEventArgs(cell.XLocation, cell.YLocation));
            }
        }

        private int CountAliveNeighbors(Cell cell)
        {
            var count = 0;

            foreach (var neighbor in cell.Neighbors())
            {
                if (_currentLiveGen.ContainsKey(neighbor.ToString()))
                {
                    count++;
                }
            }

            return count;
        }
    }
}