using BaseLibrary.DataStructures;
using DSAPractice.Tree;
namespace DSAPractice
{
    internal class Tool
    {
        public void Run()
        {
            Traversal traversalObject = new Traversal();

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

            var treeProperties = new TreeProperties();
            Console.WriteLine($"Depth : {treeProperties.MaxDeptBinaryTree(root)}");
            

        }

        

        

    }
}
