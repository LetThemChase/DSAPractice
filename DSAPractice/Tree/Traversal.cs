using BaseLibrary.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAPractice.Tree
{
    internal class Traversal
    {
        public TreeNode<int> GetTree()
        {
            TreeNode<int> root = new TreeNode<int>(5);

            root.Left = new TreeNode<int>(3);
            root.Right = new TreeNode<int>(2);

            root.Left.Left = new TreeNode<int>(1);
            root.Left.Right = new TreeNode<int>(7);

            root.Right.Left = null;
            root.Right.Right = new TreeNode<int>(5);

            root.Left.Right.Left = new TreeNode<int>(8);
            root.Left.Right.Right = null;

            root.Right.Right.Left = new TreeNode<int>(6);
            root.Right.Right.Right = null;

            return root;
        }

        //DFS
        //root, left, right
        public void PreOrder(TreeNode<int> root)
        {
            if(root == null) return;

            Console.WriteLine(root.Data);
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        public void PreOrderIterative(TreeNode<int> root)
        {
            if (root == null) return;

            Stack<TreeNode<int>> treeNodes = new Stack<TreeNode<int>>();

            treeNodes.Push(root);

            while (treeNodes.Count > 0) { 
                
                var node = treeNodes.Pop();

                Console.WriteLine(node.Data);

                if(node.Right != null) treeNodes.Push(node.Right);
                if (node.Left != null) treeNodes.Push(node.Left);
            }

        }

        //left, right, root
        public void PostOrder(TreeNode<int> root)
        {
            if (root == null) return;

            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.WriteLine(root.Data);

        }

        //left, root, right
        public void InOrder(TreeNode<int> root)
        {
            if (root == null) return;

            InOrder(root.Left);
            Console.WriteLine(root.Data);
            InOrder(root.Right);
        }

        public void InOrderIterative(TreeNode<int> root)
        {
            if (root == null) return;

            Stack<TreeNode<int>> treeNodes = new Stack<TreeNode<int>>();

            treeNodes.Push(root);

            while (treeNodes.Count > 0)
            {

                var node = treeNodes.Pop();

                Console.WriteLine(node.Data);

                if (node.Right != null) treeNodes.Push(node.Right);
                if (node.Left != null) treeNodes.Push(node.Left);
            }

        }

        //BFS
        //Time & sapce : O(n)
        public void BFS(TreeNode<int> root)
        {
            if (root == null) return ;

            Queue<TreeNode<int>> treeNodes = new Queue<TreeNode<int>>();

            treeNodes.Enqueue(root);

            while(treeNodes.Count > 0)
            {
                var node = treeNodes.Dequeue();

                Console.WriteLine(node.Data);
                if (node.Left != null) treeNodes.Enqueue(node.Left);
                if (node.Right != null) treeNodes.Enqueue(node.Right);
            }

        }

        public List<List<int>> BFSLevels(TreeNode<int> root)
        {
            if (root == null) return null;

            List<List<int>> levelOrder = new List<List<int>>();

            Queue<TreeNode<int>> treeNodes = new Queue<TreeNode<int>>();

            treeNodes.Enqueue(root);

            while (treeNodes.Count > 0)
            {
                int size = treeNodes.Count;
                List<int> level = new List<int>();
                for (int i = 0; i < size; i++) {

                    var node = treeNodes.Dequeue();

                    level.Add(node.Data);
                    Console.WriteLine(node.Data);

                    if (node.Left != null) treeNodes.Enqueue(node.Left);
                    if (node.Right != null) treeNodes.Enqueue(node.Right);
                }

                levelOrder.Add(level);
            }

            return levelOrder;

        }

        public void TraversBFSLevels(List<List<int>> bfsLevels)
        {
            if (bfsLevels == null) return;

            Console.WriteLine("BFS Levels");
            int count = 0;
            foreach (var level in bfsLevels)
            {
                Console.WriteLine($"lev : {count}");

                if (level != null)
                {
                    foreach (var data in level)
                        Console.WriteLine(data);
                }
                count++;
            }
        }

    }
}
