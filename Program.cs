using System;

namespace BaiTHBinaryTree
{
    class Node
    {
        public int info;
        public Node left, right;
    }

    class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int x)
        {
            Insert(ref root, x);
        }

        public void Insert(ref Node root, int x)
        {
            if (root == null)
            {
                root = new Node();
                root.info = x;
                root.left = null;
                root.right = null;
            }
            else
            {
                if (x < root.info)
                {
                    Insert(ref root.left, x);
                }
                else
                {
                    Insert(ref root.right, x);
                }
            }
        }

        
    }

    class Program
    {
        public bool isleafNode(Node t)
        {
            return (t.left == null && t.right == null);
        }
        //bai 1
        public int dem(Node t)
        {
            if (t == null) return 0;
            if (isleafNode(t)) return 1;
            return dem(t.left) + dem(t.right);
        }

        //bai 2
        public void tong(Node t)
        {
            int sum = 0;
            if (t != null)
            {
                tong(t.left);
                sum += t.info;
                tong(t.right);
            }

            Console.WriteLine("Tong = " + sum);
        }

        //bai3
        public void printTree(Node t)
        {
            if (t != null)
            {
                printTree(t.left);
                Console.Write(t.info + " ");
                printTree(t.right);
            }
        }

        //bai4
        public void soChan(Node t)
        {
            if (t != null)
            {
                soChan(t.left);
                if (t.info % 2 == 0)
                {
                    Console.Write(t.info + " ");
                }

                soChan(t.right);
            }
        }

        //bai 5
        public void demSoChan(Node t)
        {
            int dem = 0;
            if (t != null)
            {
                soChan(t.left);
                if (t.info % 2 == 0)
                {
                    dem++;
                }

                soChan(t.right);
            }

            Console.WriteLine("dem gia tri so chan = " + dem);
        }

        //bai 7
        public void printLeft(Node t)
        {
            if (t != null)
            {
                printLeft(t.left);
                Console.Write(t.info + " ");
            }
        }

        //bai8
        public void printTGS(Node t)
        {
            if (t != null)
            {
                Console.Write(t.info);
                printTGS(t.left);
                printTGS(t.right);
            }
        }

        //bai 9
        public void Bai9()
        {
            BinaryTree bt = new BinaryTree();
            Console.WriteLine("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap so thu : " + i + ": ");
                int so = int.Parse(Console.ReadLine());
                bt.Insert(so);
            }

            Console.WriteLine("1.Bai 1 2.Bai2 3.Bai3 4.Bai 4 5.Bai 5 6.Bai6(chưa làm) 7.Bai7 8.Bai8 9.Bai9");
            int chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Console.WriteLine(dem(bt.root));
                    break;
                case 2:
                    tong(bt.root);
                    break;
                case 3:
                    printTree(bt.root);
                    break;
                case 4:
                    soChan(bt.root);
                    break;
                case 5:
                    demSoChan(bt.root);
                    break;
                case 7:
                    printLeft(bt.root);
                    break;
                case 8:
                    printTGS(bt.root);
                    break;
                default: break;
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Bai9();
        }
    }
}