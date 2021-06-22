using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining the path of each file
            String path1 = @"";
            String path2 = @"";
            String path3 = @"";

            //Creating Trees for each file
            BST a = new BST();
            BST b = new BST();
            BST c = new BST();

            Console.WriteLine("Binary Tree #1");
            //Calls the AddBST function and passes the path of file and what BST it is to create it
            AddBST(path1, a);

            Console.WriteLine("Binary Tree #2");
            //same as before but with another
            AddBST(path2, b);

            Console.WriteLine("Binary Tree #3");
            AddBST(path3, c);

            Console.ReadLine();
        }

        //Method to add to BST
        static void AddBST(string path, BST list)
        {
            //Tries to catch any excepections
            try
            {
                //Creates array from file(path)
                string[] lines1 = File.ReadAllLines(path);
                //If the Array is empty then it will return and end the method
                if (lines1.Length == 0) { Console.WriteLine("File is Empty!!!"); Console.WriteLine(); return; }
                else
                {
                    //Converts the string array to int array
                    int[] array1 = Array.ConvertAll(lines1, int.Parse);
                    //This creates the root Node
                    list.root = list.insert(list.root, array1[0]);
                    //Loops through the array 
                    for (int i = 1; i < array1.Length; i++)
                    {
                        //Inserts the nodes calling the insert node function
                        list.insert(list.root, array1[i]);
                    }
                    //Calls Method to print out the Details of BST
                    Printout(list);
                }
            }//Prints out any errrs to console
            catch (Exception ex) { Console.WriteLine(ex.Message); Console.WriteLine(); }
            
        }
        //Prints out the details for the BST
        static void Printout(BST a)
        {
            Console.WriteLine("=====================================");

            Console.Write("In Order: ");
            a.InOrder(a.root);
            Console.WriteLine();

            Console.Write("Pre Order: ");
            a.Preorder(a.root);
            Console.WriteLine();

            Console.Write("Post Order: ");
            a.Postorder(a.root);
            Console.WriteLine();

            Console.WriteLine("Level Order: ");
            a.levelOrder(a.root);
            Console.WriteLine();

            Console.Write("Prime Numbers: ");
            a.FindPrime(a.root);
            Console.WriteLine();

            Console.WriteLine("=====================================");
            Console.WriteLine();
        }

    }
}
