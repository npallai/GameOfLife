using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Node
    {
        public Position Position { get; private set; }
        public bool IsAlive { get; set; }
        public bool IsRoot { get; set; }

        public Node(Position position, bool isAlive = false)
        {
            Position = position;
            IsAlive = isAlive;
        }
    }
}
