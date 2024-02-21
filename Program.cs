namespace GAQueueDoublyLinkedList_MeiliZheng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> newQueue = new Queue<int>();
            //Add elements to newQueue
            newQueue.Enqueue(1);
            newQueue.Enqueue(2);
            newQueue.Enqueue(3);
            newQueue.Enqueue(4);
            newQueue.Enqueue(5);
            //Print result
            Console.WriteLine("Print result after enqueue:");
            newQueue.PrintResult();
            //Dequeue
            newQueue.Dequeue();
            newQueue.Dequeue();
            //Peek result
            Console.WriteLine("Peek result after dequeue:");
            newQueue.Peek();  
            //Clear
            Console.WriteLine("=======================Clear======================");
            newQueue.Clear();
        }
    }
}