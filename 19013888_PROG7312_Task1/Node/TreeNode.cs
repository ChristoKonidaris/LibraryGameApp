using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19013888_PROG7312_Task1.Node
{
    class TreeNode<T>
    {
        //allows you to create a node and pass data of any type
        public T CallNumber { get; set; }

        public T Description { get; set; }

        //it allows children to track the parents
        public TreeNode<T> Parent { get; set;}

        //it allows parents to track the children
        public List<TreeNode<T>> Children { get; set; }
    }
}
