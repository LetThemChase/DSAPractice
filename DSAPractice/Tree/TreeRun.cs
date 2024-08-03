
using BaseLibrary.DataStructures;

namespace DSAPractice.Tree{

    public class TreeRun{

        public void Run(){

            var traversalObject = new Traversal();
            var treeProperties = new TreeProperties();

            TreeNode<int> root = traversalObject.GetTree();

            //Console.WriteLine("InOrder");
            //traversalObject.InOrder(root);

            // Console.WriteLine("PreOrder");
            // traversalObject.PreOrder(root);

            // Console.WriteLine("PreOrder Iterative");
            // traversalObject.PreOrderIterative(root);
            
            //Console.WriteLine("PostOrder");
            //traversalObject.PostOrder(root);

            //Console.WriteLine("BFS");
            //traversalObject.BFS(root);

            //var bfsLevels = traversalObject.BFSLevels(root);
            //traversalObject.TraversBFSLevels(bfsLevels);

            // Console.WriteLine($"Depth : {treeProperties.MaxDeptBinaryTree(root)}");

            Console.WriteLine($"IsBalanced : {treeProperties.IsBalancedBinaryTree(root)}");
            
            Console.WriteLine($"IsBalanced2 : {treeProperties.IsBalancedByHeight(root)}");

        }
    }
}