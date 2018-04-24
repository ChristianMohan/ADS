using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ADS
{

    public enum TraverseOrder
    {
        InOrder,
        PreOrder,
        PostOrder
    }

    public class ADSTree
    {
        private ADSNode root;

        public sealed class ADSNode
        {
            public ADSNode left;
            public ADSNode right;
            public int key;
            public int cardinality;  //  Increment each time duplicates are added
            public int height;  // Height of this node
        }

        public ADSTree()
        {
            root = null;
        }

        // Return the node where value is located
        public ADSNode find(int value)
        {
            return null;
        }

        // Inserts a node into the tree and maintains it's balance
        public void insert(ADSNode parent, int value)
        {
            ADSNode n = new ADSNode();

            if(root == null)
            {
                root = new ADSNode();

            }
            else
            {

            }
            if(value < parent.key)
            {
                if (parent.left == null)
                {
                    //create new node
                    n.key = value;
                    parent.left = n;

                }
                else
                {
                    insert(parent.right, value);

                    parent.height = Math.Max(parent.left == null ? 0 : parent.left.height,
                                             parent.right == null ? 0 : parent.right.height) + 1;

                }
            }
            else if(value > parent.key)
            {
                if(parent.right == null)
                {
                    //create new node
                    n.key = value;
                    parent.right = n;
                }
                else
                {
                    insert(parent.right, value);

                    parent.height = Math.Max(parent.right == null ? 0 : parent.right.height,
                                             parent.left == null ? 0 : parent.left.height) + 1;
                }
            }
            
        }

        // Print the tree in a particular order
        public void printTree(TraverseOrder order)
        {
        }
    }

}
