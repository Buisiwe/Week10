using System;
using System.Collections.Generic;


namespace ApplicationUI
{
    // A linked list (LL) node to 
    // store a queue entry 

    class QNode
    {

        public string key;

        public QNode next;

        // constructor to create a new linked list node 

        public QNode(string key)

        {

            this.key = key;

            this.next = null;

        }
    }
    //Queue is a generic class and T is a parameter type
    public class Queue
    {
        QNode front, rear; 

  

    public Queue() 

    { 

        this.front = this.rear = null; 

    } 
        //Create Enqueue method that doesn't return anything and take one parameter of type T.
        public void enqueue(string key)

        {
            // Create a new LL node 

            QNode temp = new QNode(key);

            // If queue is empty, then new 

            // node is front and rear both 

            if (this.rear == null)
            {

                this.front = this.rear = temp;

                return;

            }



            // Add the new node at the 

            // end of queue and change rear 

            this.rear.next = temp;

            this.rear = temp;

        }



        // Method to remove an key from queue. 

        public void dequeue()

        {

            // If queue is empty, return NULL. 

            if (this.front == null)

                return;

            // Store previous front and 

            // move front one node ahead 

            QNode temp = this.front;

            this.front = this.front.next;



            // If front becomes NULL, 

            // then change rear also as NULL 

            if (this.front == null)

                this.rear = null;

        }
    }
}
