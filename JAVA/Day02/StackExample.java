import java.util.*;

public class StackExample {
    public static void main(String[] args) {
        Stack<Integer> stack = new Stack<>();
        
        stack.push(10);
        stack.push(20);
        stack.push(30);
        
        System.out.println("Stack: " + stack);
        
        int poppedElement = stack.pop();
        System.out.println("Popped Element: " + poppedElement);
        
        int topElement = stack.peek();
        System.out.println("Top Element: " + topElement);
        
        boolean isEmpty = stack.isEmpty();
        System.out.println("Is Stack Empty? " + isEmpty);
    }
}
