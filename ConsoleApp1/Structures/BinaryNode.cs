using System.Collections.Generic;

namespace CodingAlgorithm
{
    public class BinaryNode
    {
        public BinaryNode(int value)
        {
            this.value = value;
            children = new List<BinaryNode>();
        }

        public List<BinaryNode> children;

        public BinaryNode[] childs;

        public int value;
    }
}