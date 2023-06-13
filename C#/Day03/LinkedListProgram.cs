class Node {
    public int data;
    public Node next;
    
    public Node(int data) {
        this.data = data;
        this.next = null;
    }
}

class LinkedList {
    public Node head;
    
    public LinkedList() {
        this.head = null;
    }
    
    public void Insert(int data) {
        Node newNode = new Node(data);
        
        if (head == null) {
            head = newNode;
        } else {
            Node temp = head;
            while (temp.next != null) {
                temp = temp.next;
            }
            temp.next = newNode;
        }
    }
    
    public void Display() {
        Node temp = head;
        while (temp != null) {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        Console.WriteLine();
    }
}

public class LinkedListProgram {
    public static void Main(string[] args) {
        LinkedList linkedList = new LinkedList();
        
        linkedList.Insert(10);
        linkedList.Insert(20);
        linkedList.Insert(30);
        
        linkedList.Display(); // Output: 10 20 30
    }
}
