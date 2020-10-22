﻿using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Binary Search Tree");
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(65);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(63);
            bst.Insert(67);
            Console.WriteLine("Size of Tree: " + bst.SizeOfTree());
            bst.BinarySearch(63);
        }
    }
}
