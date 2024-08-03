using BaseLibrary.DataStructures;

namespace DSAPractice.Tree{

    public class TreeProperties{

        public int MaxDeptBinaryTree(TreeNode<int> root){
            
            if(root == null) return 0;
                 
            return 1 + Math.Max(MaxDeptBinaryTree(root.Left), MaxDeptBinaryTree(root.Right)) ;

        }

        //Tree is balanced if : Max height is log(n)
        //If For every node : Abs( height(left) - heigt(right) <= 1 )

        //O(n2)
        public bool IsBalancedBinaryTree(TreeNode<int> root){
            
            if (root == null) return true;

            if(Math.Abs( MaxDeptBinaryTree(root.Left) - MaxDeptBinaryTree(root.Right)) > 1)
                return false;

            return IsBalancedBinaryTree(root.Left) && IsBalancedBinaryTree(root.Right);
            
        }

        public bool IsBalancedByHeight(TreeNode<int> root){
            return BalancedByHeight(root) != -1;
        }

        //Logic of Recursion : Check from leaf node for height difference and return -1
        //o(n) , o(n) for skew
        public int BalancedByHeight(TreeNode<int> root){
            
            if (root == null) return 0;

            int lh = BalancedByHeight(root.Left);
            if (lh == -1) return -1;

            int rh = BalancedByHeight(root.Right);
            if (rh == -1) return -1;

            if(Math.Abs(lh - rh) > 1) 
                return -1;

            return 1 + Math.Max(lh,rh);
        }


    }

}