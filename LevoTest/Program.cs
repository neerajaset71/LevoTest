using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevoTest
{
    class Program
    {
        public class LinkedNode
        {
            public int Number { get; set; }
            public LinkedNode Next { get; set; }
            public LinkedNode(int num)
            {
                Number = num;
                Next = null;
            }
        }
        public class LinkedNodeList
        {
            private LinkedNode _num;
            public LinkedNode Num
            {
                get
                {
                    return _num;
                }
                set
                {
                    _num = value;
                }
            }
            public LinkedNodeList(LinkedNode num)
            {
                Num = num;
            }
            public void Add(LinkedNode num)
            {
                LinkedNode temp = Num;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = num;
                num.Next = null;
            }
            public void DisplayAll()
            {
                LinkedNode temp = Num;
                do
                {
                    Console.WriteLine(temp.Number);
                    temp = temp.Next;
                } while (temp != null);
            }
            public void GetNthElementFromTail(int nPos)
            {
                try
                {
                    if (Num == null || nPos < 1)
                    {
                        Console.WriteLine("Error: List does not exist or there are no elements in the list.");
                    }
                    LinkedNode pntr1 = Num;
                    LinkedNode pntr2 = Num;
                    for (int i = 0; i < nPos; ++i)
                    {
                        if (pntr2 == null)
                        {
                            Console.WriteLine("Error: While moving pointer 2, it becomes NULL, i.e. reaches the end of the list and it means list has less than n nodes, so its not possible to find nth position element from the tail.");
                            return;
                        }
                        pntr2 = pntr2.Next;
                    }
                    while (pntr2 != null)
                    {
                        pntr1 = pntr1.Next;
                        pntr2 = pntr2.Next;
                    }                   
                    Console.WriteLine(nPos + "th Element from the tail(end) of the list:" + pntr1.Number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            //Part A - Puzzle One - Linked List
            Console.WriteLine("Part A - Puzzle One - Linked List");

            LinkedNodeList numberList = new LinkedNodeList(new LinkedNode(0));
            numberList.Add(new LinkedNode(1));
            numberList.Add(new LinkedNode(2));
            numberList.Add(new LinkedNode(3));
            numberList.Add(new LinkedNode(4));
            numberList.Add(new LinkedNode(5));
            numberList.Add(new LinkedNode(6));
            numberList.Add(new LinkedNode(7));
            numberList.Add(new LinkedNode(8));
            numberList.Add(new LinkedNode(9));
            numberList.Add(new LinkedNode(10));
            numberList.Add(new LinkedNode(11));
            
            Console.WriteLine("Singly Linked List elements:");
            numberList.DisplayAll();

            int n = 5;            
            numberList.GetNthElementFromTail(n);

            //Part A - Puzzle Two - Reverse Words
            Console.WriteLine("Part A - Puzzle Two - Reverse Words");            
            string strSentence = "Hello! My name is 'Neeraj Joshi' and I'm doing good. How are you doing?";
            Console.WriteLine("Input String : " + strSentence);
            string modifiedSentence = ReverseCharInWords(strSentence);
            Console.WriteLine("Output String : " + modifiedSentence);

            Console.ReadKey();
        }
        public static string ReverseCharInWords(string strSentence)
        {
            try
            {
                if (!string.IsNullOrEmpty(strSentence))
                {
                    StringBuilder strbuilder = new StringBuilder();
                    List<char> charList = new List<char>();
                    for (int i = 0; i < strSentence.Length; i++)
                    {
                        if (strSentence[i] == ' ' || i == strSentence.Length - 1)
                        {
                            if (i == strSentence.Length - 1)
                            {
                                charList.Add(strSentence[i]);
                            }
                            for (int j = charList.Count - 1; j >= 0; j--)
                            {
                                strbuilder.Append(charList[j]);
                            }
                            strbuilder.Append(' ');
                            charList = new List<char>();
                        }
                        else
                        {
                            charList.Add(strSentence[i]);
                        }
                    }                   
                    return "Output String : " + strbuilder.ToString().TrimEnd();
                }
                else
                {
                    return "Error: String is either null or empty";
                }
            }
            catch (Exception)
            {
                return "Exception Occured";
            }
        }
    }
}
