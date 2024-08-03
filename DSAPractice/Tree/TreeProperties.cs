using BaseLibrary.DataStructures;

namespace DSAPractice.Tree{

    public class TreeProperties{

        public int MaxDeptBinaryTree(TreeNode<int> root){
            int dept = 0;
            
            if(root != null) 
                dept = Math.Max(MaxDeptBinaryTree(root.Left), MaxDeptBinaryTree(root.Right)) + 1;

            return dept;
        }

    }

}