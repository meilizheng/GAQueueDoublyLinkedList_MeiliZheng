using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GAQueueDoublyLinkedList_MeiliZheng
{
    public class Queue<T>
    {
        //Nested QueueNode class
        class QueueNode<T>
        {
            //Property
            public T Value { get; set; }
            public QueueNode<T> Next { get; set; }

            public QueueNode<T> Previous { get; set; }

            //Constructor
            public QueueNode(T value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }
        }
        //Field
        private QueueNode<T> front;
        private QueueNode<T> rear;
        private int count;

        //Constructor
        public Queue()
        {
            front = null;
            rear = null;
            count = 0;
        }

        //Property for count
        public int Count { get => count; set => count = value; }

        //Enqueue Method 
        public void Enqueue(T value)
        {
            QueueNode<T> newNode = new QueueNode<T>(value); // Create a new node with the value.

            if (rear == null)
            {
                // If the queue is empty, both front and rear are the new node.
                front = newNode;
                rear = newNode;
            }
            else
            {
                // Link the new node after the current rear.
                rear.Next = newNode;
                newNode.Previous = rear;
                // Update the rear to be the new node.
                rear = newNode;
            }

            count++; // Increment the count of elements.
        }

        //Dequeue Method
        public T Dequeue()
        {
            if (front == null)
                throw new InvalidOperationException("Queue is empty."); // Check for an empty queue.

            T value = front.Value; // Store the value to return.

            // Move the front pointer to the next node.
            front = front.Next;

            if (front == null)
                rear = null; // If the queue becomes empty, adjust the rear as well.
            else
                front.Previous = null; // Remove the reference to the dequeued node.

            count--; // Decrement the count of elements.
            return value; // Return the dequeued value.

        }

        //Peek Method
        public T Peek()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty."); // Check for an empty queue.
            }

            Console.WriteLine(front.Value);
            return front.Value; // Return the value of the front node.
        }

        //Clear Method
        public void Clear()
        {
            front = null; // Reset the front to null.
            rear = null; // Reset the rear to null.
            count = 0; // Reset the count to 0.
        }

        //PrintResult Method
        public void PrintResult()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            QueueNode<T> current = front; // Start from the front node
            while (current != null)       // Iterate until reaching the end of the queue
            {
                Console.WriteLine(current.Value); // Print the value of the current node
                current = current.Next;            // Move to the next node
            }
        }
    }
}
