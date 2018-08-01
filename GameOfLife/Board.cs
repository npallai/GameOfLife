using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Board
    {
        private readonly QuadTreeNode CellQuadTree;

        public Board()
        {
            CellQuadTree = new QuadTreeNode(new Position(long.MinValue, long.MaxValue, long.MinValue, long.MaxValue));
            CellQuadTree = QuadTreeNode.CreateQuadTree(new List<Tuple<long, long>>(), new Position(long.MinValue, long.MaxValue, long.MinValue, long.MaxValue));

            //CellQuadTree.CreateQuadTree(new List<Tuple<long, long>>(), CellQuadTree.Position);
        }

    }
}
