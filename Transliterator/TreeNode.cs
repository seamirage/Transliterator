using System.Collections.Generic;
using System.Linq;

namespace Transliterator
{
    public class TreeNode
    {
        internal TreeNode(Dictionary<char, TreeNode> childNodes)
        {
            this.childNodes = childNodes;
        }

        public TreeNode()
        {
            childNodes = new Dictionary<char, TreeNode>();
        }

        public TreeNode(char relatedLetter) : this()
        {
            IsEndpoint = true;
            this.RelatedLetter = relatedLetter;
        }

        public TreeNode GetChild(char c)
        {
            if (childNodes.ContainsKey(c))
            {
                return childNodes[c];
            }
            else
            {
                return null;
            }
        }

        public void AddChild(TreeNode node, char letter)
        {
            childNodes.Add(letter, node);
        }

        public bool IsLeaf()
        {
            return !childNodes.Any();
        }

        public IEnumerable<KeyValuePair<char, TreeNode>> EnumerateChilds()
        {
            return childNodes;
        }

        public bool IsEndpoint { get; private set; }
        public char RelatedLetter;
        private readonly Dictionary<char, TreeNode> childNodes;
    }
}