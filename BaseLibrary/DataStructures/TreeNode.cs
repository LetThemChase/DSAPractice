using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.DataStructures
{
    public class TreeNode<T>
    {
        public T Data;
        public TreeNode<T> Left;
        public TreeNode<T> Right;
        
        public TreeNode(T data) {
            Data = data;
            Left = Right = null;
        }
    }
}
