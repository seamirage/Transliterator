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

        public bool TrySearchMaxOccurence(string text, ref int index, out char relatedLetter)
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
                        relatedLetter = current.RelatedLetter;
                        return true;
                    }
                    else
                    {
                        relatedLetter = default(char);
                        return false;
                    }
                }
            }

            if (current.IsEndpoint)
            {
                relatedLetter = current.RelatedLetter;
                return true;
            }
            else
            {
                relatedLetter = default(char);
                --index;
                return false;    
            }
        }
      
        private TreeNode root;
    }
}
