namespace IteratorPattern
{
    internal class TreeNode<T>
    {
        public T Value { get; }
        public TreeNode<T>? Left { get; }
        public TreeNode<T>? Right { get; }
        public TreeNode<T>? Parent { get; set; }

        public TreeNode(T value)
        {
            Value = value;
        }

        public TreeNode(T value, TreeNode<T> left, TreeNode<T> right)
        {
            Value = value;
            Left = left;
            Right = right;

            left.Parent = right.Parent = this;
        }

        public IEnumerable<T> PreOrder
        {
            get
            {
                return TreeNode<T>.GetPreOrder(this);
            }
        }

        private static IEnumerable<T> GetPreOrder(TreeNode<T> node)
        {
            if (node == null)
            {
                yield break;
            }

            // Root value first
            yield return node.Value;

            // Then all left values
            if (node.Left != null)
            {
                foreach (var val in TreeNode<T>.GetPreOrder(node.Left))
                {
                    yield return val;
                }
            }

            // Then all right values
            if (node.Right != null)
            {
                foreach (var val in TreeNode<T>.GetPreOrder(node.Right))
                {
                    yield return val;
                }
            }
        }
    }
}
