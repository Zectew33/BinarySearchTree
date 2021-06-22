using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace week9Lab
{
    class BST
    {
        public Node root;
        public BST() { root = null; }

        //Inserts the Nodes when called
        public Node insert(Node node, int num)
        {
            //Creates new node
            Node newnode = new Node(num);
            Node x = node;
            Node y = null;

            //while the node is not null
            while (x != null)
            {
                y = x;
                if (num < x.num) { x = x.left; }
                else { x = x.right; }
            }
            if (y == null) { y = newnode; }
            else if (num < y.num) { y.left = newnode; }
            else { y.right = newnode; }
            return y;
        }

        //Prints nodes out in Order
        public void InOrder(Node node)
        {
            //Checks if node is null
            if (node == null)
            {
                //Stops method since there are no more nodes
                return;
            }
            //Prints all left nodes
            InOrder(node.left);
            Console.Write(node.num + " ");
            //Then Prints all right nodes
            InOrder(node.right);
        }


        //Pretty much same as InOrder but Prints ind Post Order
        public void Postorder(Node node)
        {
            if (node == null) 
            { 
                return; 
            }

            Postorder(node.left);
            Postorder(node.right);

            Console.Write(node.num + " ");
        }

        public void Preorder(Node node)
        {
            if (node == null) 
            {
                return;
            }
                

            Console.Write(node.num + " ");
            Preorder(node.left);
            Preorder(node.right);
        }

        //Prints in level Order
        public void levelOrder(Node root)
        {
            //Checks if Root Node is null
            if (root == null)
            {
                return;
            }
            //Creates a Queue
            Queue<Node> q = new Queue<Node>();
            //Enqueues the Root
            q.Enqueue(root);
            q.Enqueue(null);

            //Untill the queue is empty
            while (q.Count > 0)
            {
                //Makes current node the head of Queue
                Node curr = (Node)q.Peek();
                //Dequeues head
                q.Dequeue();
                //checks if Head is null
                if (curr == null)
                {
                    //checks if queue is empty
                    if (q.Count > 0)
                    {
                        //Enqueues Null
                        q.Enqueue(null);
                        //Prints space
                        Console.WriteLine();
                    }
                }
                else
                {   //checks if the left node is not null
                    if (curr.left != null)
                        //then enqueues it
                        q.Enqueue(curr.left);
                    //checks if right node is not null
                    if (curr.right != null)
                        //then enqueues it
                        q.Enqueue(curr.right);
                    //Prints the current node
                    Console.Write(curr.num + " ");
                }
            }
        }
        //Finds the Prime Node
        public void FindPrime(Node node)
        {
            //Checks if node is null
            if (node == null)
            {
                return;
            }
            //calls all left nodes
            FindPrime(node.left);
            //call isPrime method it return true or false weither its Prime or not
            if (isPrime(node.num))
            {
                //If it is a prime then prints the prime
                Console.Write(node.num + " ");
            }
            //Calls all the right nodes
            FindPrime(node.right);
        }

        //Checks if number is prime or not
        public static Boolean isPrime(int n)
        {
            //Set to true
            Boolean b = true;
            //sqrts number 
            int number2 = (int)Math.Sqrt(n);
            //Makes sure the number is over 1
            if (!(n <= 1))
            {
                for (int num = 2; num <= number2; num++)
                {
                    //Find the reminder and if it equals 0
                    if ((n % num) == 0)
                    {
                        //if it does then number is not a prime
                        b = false;
                        break;
                    }
                }
                //returns result
                return (b);
            }
            return false;
        }
    }
}
