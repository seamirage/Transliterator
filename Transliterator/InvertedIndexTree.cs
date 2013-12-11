using System;

namespace Transliterator
{
    public class InvertedIndexTree
    {
        public InvertedIndexTree()
        {
            root = new TreeNode();
        }

        public void Add(string word, char relatedLetter)
        {
            TreeNode current = root;
            int index = 0;

            while (index < word.Length)
            {
                TreeNode childNode = current.GetChild(word[index]);
                if (null != childNode)
                {
                    ++index;
                    current = childNode;
                }
                else
                {
                    current.AddChild(new TreeNode(relatedLetter), word[index]);
                }
            }
        }

        public char SearchMaxOccurence(string text, ref int index)
        {
            TreeNode current = root;

            while (index < text.Length)
            {
                TreeNode childNode = current.GetChild(text[index]);
                if (null != childNode)
                {
                    ++index;
                    current = childNode;
                }
                else
                {
                    if (current.IsEndpoint)
                    {
                        return current.RelatedLetter;
                    }
                    else
                    {
                        throw new ArgumentException("Unknown letter");
                    }
                }
            }

            if (current.IsEndpoint)
            {
                return current.RelatedLetter;
            }

            throw new ArgumentException("Unknown letter");
        }

        private TreeNode root;
    }
}
