﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_and_Traversals
{
    public class Node<T>
    {
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public bool HasParent { get; set; }

        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public Node(T value)
            : this()
        {
            this.Value = value;
        }
    }
}