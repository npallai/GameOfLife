using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class QuadTreeNode : Node
    {
        public QuadTreeNode NorthWest { get; set; }
        public QuadTreeNode NorthEast { get; set; }
        public QuadTreeNode SouthWest { get; set; }
        public QuadTreeNode SouthEast { get; set; }


        public static QuadTreeNode CreateQuadTree(IEnumerable<Tuple<long, long>> initialCells, Position position)
        {
            var node = new QuadTreeNode(position);


            // while (position.XMaxCoordinate != position.XMinCoordinate)


            if (position.XMaxCoordinate == position.XMinCoordinate)
            {
                if (initialCells.Contains(new Tuple<long, long>(position.XMinCoordinate, position.YMinCoordinate)))
                    node.IsAlive = true;

                return node;
            }

            //To prevent funky overflows for finding moving midpoint remember - (low & high) + ((low ^ high) >> 1)
            node.NorthWest = CreateQuadTree(initialCells, new Position(position.XMinCoordinate, (position.XMinCoordinate & position.XMaxCoordinate) + ((position.XMinCoordinate ^ position.XMaxCoordinate) >> 1), (position.YMinCoordinate & position.YMaxCoordinate) + ((position.YMinCoordinate ^ position.YMaxCoordinate) >> 1) + 1, position.YMaxCoordinate));
            node.NorthEast = CreateQuadTree(initialCells, new Position((position.XMinCoordinate & position.XMaxCoordinate) + ((position.XMinCoordinate ^ position.XMaxCoordinate) >> 1) + 1, position.XMaxCoordinate, (position.YMinCoordinate & position.YMaxCoordinate) + ((position.YMinCoordinate ^ position.YMaxCoordinate) >> 1) + 1, position.YMaxCoordinate));
            node.SouthWest = CreateQuadTree(initialCells, new Position(position.XMinCoordinate, (position.XMinCoordinate & position.XMaxCoordinate) + ((position.XMinCoordinate ^ position.XMaxCoordinate) >> 1), position.YMinCoordinate, (position.YMinCoordinate & position.YMaxCoordinate) + ((position.YMinCoordinate ^ position.YMaxCoordinate) >> 1)));
            node.SouthEast = CreateQuadTree(initialCells, new Position((position.XMinCoordinate & position.XMaxCoordinate) + ((position.XMinCoordinate ^ position.XMaxCoordinate) >> 1) + 1, position.XMaxCoordinate, position.YMinCoordinate, (position.YMinCoordinate & position.YMaxCoordinate) + ((position.YMinCoordinate ^ position.YMaxCoordinate) >> 1)));

            return node;
        }

        public QuadTreeNode(Position position, bool isAlive = false) : base(position, isAlive)
        {
        }

    }
}
