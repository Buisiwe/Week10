using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationUI
{
    // A linked list (LL) node to and store a queue entry 
    class Queue
    {
        private readonly int maxsize = 10;
        private string[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems;

        public Queue()
        {
            store = new string[maxsize];
        }

        public Queue(int size)
        {
            maxsize = size;
            store = new string[maxsize];
        }

        public void Enqueue(string value)
        {
            numItems++;
            store[tail] = value;
            if (++tail == maxsize)
            {
                tail = 0;
            }
        }

        public string Dequeue()
        {
            string headItem;
            numItems--;
            headItem = store[head];
            if (++head == maxsize)
            {
                head = 0;
            }

            return headItem;

        }

        public bool IsEmpty()
        {
            return tail == 0; //returns the boolean result of the comparison between head and 0
        }

        public bool IsFull()
        {
            return tail == maxsize;
        }
        public int CountQueue() //counts the number of items inside the queue
        {
            return tail - head;
        }

        public int Tail //property
        {
            set { this.tail = value; }
            get { return tail; }
        }

    }
}
