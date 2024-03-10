using System;
using System.Collections.Generic;

namespace CS_ex
{
    internal class Program
    {
        public static Queue<int> MergeQueuesInNode(Node<Queue<int>> lst)
        {
            Queue<int> mergedQueue = new Queue<int>();
            Node<Queue<int>> current = lst;
            mergedQueue = current.GetValue();
            current = current.GetNext(); 

            while (current != null)
            {
                mergedQueue = MergeTwoQueues(mergedQueue, current.GetValue());
                current = current.GetNext(); 
            }

            return mergedQueue;
        }


        public static Queue<int> MergeTwoQueues(Queue<int> queue1, Queue<int> queue2)
        {
            Queue<int> mergedQueue = new Queue<int>();

            while (queue1.Count() > 0 && queue2.Count() > 0)
            {
                if (queue1.Peek() < queue2.Peek())
                {
                    mergedQueue.Enqueue(queue1.Dequeue());
                }
                else
                {
                    mergedQueue.Enqueue(queue2.Dequeue());
                }
            }

            while (queue1.Count() > 0)
            {
                mergedQueue.Enqueue(queue1.Dequeue());
            }

            while (queue2.Count() > 0)
            {
                mergedQueue.Enqueue(queue2.Dequeue());
            }

            return mergedQueue;
        }
        public static int HowManyCats(Node<Cat> node,Cat other) 
        {
            int count = 0;
            if (node == null)
            {
                return 0;
            }
            else
            {
                if(node.GetValue().getBirthday().equals(other.getBirthday()))
                {
                    count++;
                }
                count += HowManyCats(node.GetNext(), other);
            }
            return count;
        }
        public static Queue<Cat> BuildCats(Node<Cat> node)
        {
            Node<Cat> head = node;
            Queue<Cat> queue= new Queue<Cat>();

            while(node != null)
            {
                if(HowManyCats(head, node.GetValue()) >= 5)
                {
                    queue.Enqueue(node.GetValue());
                }
                    node = node.GetNext();
            }

            return queue;
        }
        public static void RemoveDuplicates(LinkedList<Triple> list)
        {
            Node<Triple> current = list.GetHead();
            while (current != null)
            {
                Node<Triple> runner = current;
                while (runner.GetNext() != null)
                {
                    if (current.GetValue().SameVals(runner.GetNext().GetValue()))
                    {
                        runner.SetNext(runner.GetNext().GetNext());
                    }
                    else
                    {
                        runner = runner.GetNext();
                    }
                }
                current = current.GetNext();
            }
        }

        public static LinkedList<Card> InsertCard(LinkedList<Card> cards, Card c)
        {
            if (cards.GetHead() == null || !cards.GetHead().GetValue().GetColor().Equals(c.GetColor()))
            {
                cards.AddFirst(c);
                return cards;
            }

            string color = c.GetColor();
            int maxNumber = Int32.MinValue;
            Node<Card> maxNode = null;
            Node<Card> prevMaxNode = null;
            Node<Card> current = cards.GetHead();
            while (current != null)
            {
                if (current.GetValue().GetColor().Equals(color) && current.GetValue().GetDigit() > maxNumber)
                {
                    maxNumber = current.GetValue().GetDigit();
                    prevMaxNode = maxNode;
                    maxNode = current;
                }
                current = current.GetNext();
            }

            if (prevMaxNode != null)
            {
                Node<Card> newNode = new Node<Card>(c);
                newNode.SetNext(maxNode);
                prevMaxNode.SetNext(newNode);
            }
            else
            {
                cards.AddFirst(c);
            }
            return cards;

        }

        public static int QueueToNumber(Queue<int> queue)
        {
            if(queue.IsEmpty())
            { 
                return 0; 
            }
            return queue.Dequeue() + 10 * QueueToNumber(queue);
        }

        public static int MostSigDigit(Node<Queue<int>> lst) 
        {
            Node<Queue<int>> current = lst;
            int max = int.MinValue;
            while (current != null)
            {
                int temp = QueueToNumber(current.GetValue());
                if(max < temp)
                {
                    max = temp;
                }
                current = current.GetNext();
            }

            return intMostSignificantDigit(max);
        }
        public static int intMostSignificantDigit(int num)
        {
            //works only for positiv num
            while(num > 10) 
            {
                num /= 10;
            }
            return num;
        }
        public static bool IsQueueSababi(Queue<Char> queue)
        {
            Queue<Char> temp = new Queue<char>();
            char last = queue.Peek();
            temp.Enqueue(queue.Dequeue());
            
            while (queue.Peek() != '*' )
            {

                if(last != queue.Peek())
                {
                    temp.Enqueue(queue.Peek());
                    last = queue.Peek();
                }
                queue.Dequeue();
            }
            //removing the char '*'
            queue.Dequeue();
            while (!temp.IsEmpty()) 
            {
                if(temp.Dequeue() != queue.Dequeue())
                {
                    return false;
                }
            }
            if(!queue.IsEmpty())
            { return false; }
            return true;
        }

        public static void Main(string[] args)
        {

            //LinkedList<Triple> list = new LinkedList<Triple>();
            //list.AddLast(new Triple(1, 2, 3));
            //list.AddLast(new Triple(1, 2, 3));
            //list.AddLast(new Triple(1, 2, 3));
            //list.AddLast(new Triple(1, 2, 3));
            //list.AddLast(new Triple(1, 8, 3));
            //list.AddLast(new Triple(1, 8, 9));
            //list.AddLast(new Triple(3, 2, 1));
            //list.AddLast(new Triple(8, 1, 9));

            //Console.WriteLine( list.ToString());
            //RemoveDuplicates(list);
            //Console.WriteLine(list.ToString());
            //LinkedList<Card> CardList = new LinkedList<Card>();
            //CardList.AddLast(new Card(1, "R"));
            //CardList.AddLast(new Card(2, "R"));
            //CardList.AddLast(new Card(3, "Y"));
            //CardList.AddLast(new Card(1, "G"));
            //CardList.AddLast(new Card(8, "G"));
            //CardList.AddLast(new Card(7, "Y"));

            //Console.WriteLine(CardList);
            //InsertCard(CardList, new Card(5, "R"));
            //Console.WriteLine(CardList);

            //LinkedList<Cat> CatList = new LinkedList<Cat>();
            //CatList.AddLast(new Cat(1, "R",new Date(1,1,2015)));
            //CatList.AddLast(new Cat(2, "i", new Date(1, 2, 2015)));
            //CatList.AddLast(new Cat(3, "p", new Date(1, 1, 2015)));
            //CatList.AddLast(new Cat(4, "j", new Date(8, 1, 2015)));
            //CatList.AddLast(new Cat(5, "y", new Date(1, 1, 2015)));
            //CatList.AddLast(new Cat(6, "g", new Date(11, 11, 2011)));
            //CatList.AddLast(new Cat(7, "u", new Date(1, 1, 2015)));
            //CatList.AddLast(new Cat(8, "R", new Date(17, 12, 2024)));
            //CatList.AddLast(new Cat(9, "R", new Date(1, 1, 2015)));
            //CatList.AddLast(new Cat(10, "R", new Date(17, 12, 2024)));
            //CatList.AddLast(new Cat(11, "R", new Date(1, 1, 2010)));
            //CatList.AddLast(new Cat(12, "R", new Date(17, 12, 2024)));
            //CatList.AddLast(new Cat(13, "R", new Date(1, 1, 2010)));
            //CatList.AddLast(new Cat(14, "R", new Date(17, 12, 2024)));
            //CatList.AddLast(new Cat(15, "R", new Date(1, 1, 2010)));

            //Console.WriteLine(BuildCats(CatList.GetHead()));

            //Queue<int> queue1 = new Queue<int>();
            //queue1.Enqueue(1);
            //queue1.Enqueue(2);
            //queue1.Enqueue(3);
            //queue1.Enqueue(8);
            //queue1.Enqueue(9);

            //Queue<int> queue2 = new Queue<int>();
            //queue2.Enqueue(4);
            //queue2.Enqueue(5);
            //queue2.Enqueue(6);
            //queue2.Enqueue(7);

            ////queue2.Enqueue(10);

            //Queue<int> queue3 = new Queue<int>();
            //queue3.Enqueue(0);
            //queue3.Enqueue(4);
            //queue3.Enqueue(5);
            //queue3.Enqueue(7);
            ////queue3.Enqueue(11);

            //LinkedList<Queue<int>> linkedList= new LinkedList<Queue<int>>();
            //linkedList.AddFirst(queue1);
            //linkedList.AddFirst(queue2);
            //linkedList.AddFirst(queue3);
            //Console.WriteLine(MergeTwoQueues(queue1,queue2));
            //Console.WriteLine(MergeQueuesInNode(linkedList.GetHead()));
            //Console.WriteLine(QueueToNumber(queue1));
            //Console.WriteLine(MostSigDigit(linkedList.GetHead()));
            
            
            //Queue<Char> queue = new Queue<Char>();
            //queue.Enqueue('A');
            //queue.Enqueue('A');
            //queue.Enqueue('A');
            //queue.Enqueue('A');
            //queue.Enqueue('B');
            //queue.Enqueue('B');
            //queue.Enqueue('B');
            //queue.Enqueue('A');
            //queue.Enqueue('A');
            //queue.Enqueue('A');
            //queue.Enqueue('C');
            //queue.Enqueue('*');
            //queue.Enqueue('A');
            //queue.Enqueue('B');
            //queue.Enqueue('A');
            //queue.Enqueue('C');

            //Console.WriteLine(IsQueueSababi(queue));
        }
    }
}