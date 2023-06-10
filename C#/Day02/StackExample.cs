using System;
using System.Collections.Generic;

public class StackExample {
    public static void Main(string[] args) {
        Stack<int> stack = new Stack<int>();
        
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        
        Console.WriteLine("Stack: " + string.Join(", ", stack));
        
        int poppedElement = stack.Pop();
        Console.WriteLine("Popped Element: " + poppedElement);
        
        int topElement = stack.Peek();
        Console.WriteLine("Top Element: " + topElement);
        
        bool isEmpty = stack.Count == 0;
        Console.WriteLine("Is Stack Empty? " + isEmpty);
    }
}
