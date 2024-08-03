using BaseLibrary.DataStructures;

namespace DSAPractice.Tree{

    public class TreeProperties{

        public int MaxDeptBinaryTree(TreeNode<int> root){
            
            if(root == null) return 0;
                 
            return 1 + Math.Max(MaxDeptBinaryTree(root.Left), MaxDeptBinaryTree(root.Right)) ;

        }

    }

}