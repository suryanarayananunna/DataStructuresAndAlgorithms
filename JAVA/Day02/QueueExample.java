import java.util.*;

public class QueueExample {
    public static void main(String[] args) {
        Queue<Integer> queue = new LinkedList<>();
        
        queue.offer(10);
        queue.offer(20);
        queue.offer(30);
        
        System.out.println("Queue: " + queue);
        
        int removedElement = queue.poll();
        System.out.println("Removed Element: " + removedElement);
        
        int frontElement = queue.peek();
        System.out.println("Front Element: " + frontElement);
        
        boolean isEmpty = queue.isEmpty();
        System.out.println("Is Queue Empty? " + isEmpty);
    }
}
