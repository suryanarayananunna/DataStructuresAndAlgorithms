using System;
using System.Collections.Generic;

public class QueueExample {
    public static void Main(string[] args) {
        Queue<int> queue = new Queue<int>();
        
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
         
        Console.WriteLine("Queue: " + string.Join(", ", queue));
        
        int removedElement = queue.Dequeue();
        Console.WriteLine("Removed Element: " + removedElement);
        
        int frontElement = queue.Peek();
        Console.WriteLine("Front Element: " + frontElement);
        
        bool isEmpty = queue.Count == 0;
        Console.WriteLine("Is Queue Empty? " + isEmpty);
    }
}
