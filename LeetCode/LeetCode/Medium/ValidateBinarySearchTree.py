from typing import Optional



class TreeNode:

    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:

    def isValidBST(self, root: Optional[TreeNode]) -> bool:

        return self.validate(root, -2**32, 2**32)


    def validate(self, node: Optional[TreeNode], min, max) -> bool:
        if (node == None):
            return True
        if(node.val<=min or node.val>= max):
            return False
        return self.validate(node.left,min,node.val) and self.validate(node.right,node.val,max)


print(Solution().isValidBST(TreeNode()))
