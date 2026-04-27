using IteratorPattern;

/*
 Create Tree structure
       1
      / \
     2   3
    / \
   4   5
*/

var node4 = new TreeNode<int>(4);
var node5 = new TreeNode<int>(5);
var node2 = new TreeNode<int>(2, node4, node5);

var node3 = new TreeNode<int>(3);
var root = new TreeNode<int>(1, node2, node3);

Console.WriteLine("Preorder Traversal:");

foreach (var val in root.PreOrder)
{
    Console.Write(val + " ");
}
