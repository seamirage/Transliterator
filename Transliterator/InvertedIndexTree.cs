using System;
using System.Collections.Generic;
using System.Linq;

namespace Transliterator
{
    public class InvertedIndexTree
    {
        public InvertedIndexTree()
        {
            root = new TreeNode();
        }

        public void Load(IEnumerable<KeyValuePair<string, char>> relations)
        {
            foreach (var relation in relations.OrderBy(x => x.Key))
            {
                Add(relation.Key, relation.Value);
            }
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
                    current = childNode;
                }
                else
                {
                    if (index == word.Length - 1)
                    {
                        current.AddChild(new TreeNode(relatedLetter), word[index]);
                    }
                    else
                    {
                        TreeNode newCurrent = new TreeNode();
                        current.AddChild(newCurrent, word[index]);
                        current = newCurrent;
                    }
                }
                ++index;
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
                        throw new UnknownSequenceOfSymbolsException(text[index], index);
                    }
                }
            }

            if (current.IsEndpoint)
            {
                return current.RelatedLetter;
            }

            throw new UnknownSequenceOfSymbolsException(text[0], 0);
        }

        private TreeNode root;
    }
}
