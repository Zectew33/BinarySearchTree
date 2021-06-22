using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9Lab
{
    //Node class
    class Node
    {
        //variables for Node
        public Node right;
        public Node left;
        public int num;

        //Node Constructor
        public Node (int num)
        {
            this.num = num;
            left = null;
            right = null;
        }
    }
}
