using System;

class Node
{
    public int data;
    public Node next;

    public Node(int input)
    {
        data = input;
        next = null;
    }
}
class LinkedList
{
    private Node head;

    public void add(int input)
    {
        Node newNode = new Node(input);
        newNode.next = head;
        head = newNode;
    }
    public void delete()
    {
        head = head.next;
    }
    public int get()
    {
        if (head == null) return -1;
        return head.data;
    }
}
class LLStack
{
    LinkedList link = new LinkedList();
    public void push(int input)
    {
        link.add(input);
        Console.WriteLine("Linked Input : " + input);
    }
    public int pop()
    {
        int temp = link.get();
        link.delete();
        return temp;
    }
}
class AStack
{
    private int top;
    private int size;
    private int[] Array;

    public AStack(int stSize)
    {
        top = -1;
        size = stSize;
        Array = new int[size];
    }
    public Boolean isEmpty()
    {
        return top == -1;
    }
    public Boolean isFull()
    {
        return top == size - 1;
    }
    public void push(int data)
    {
        if (isFull())
        {
            Console.WriteLine("배열이 가득찼습니다.");
        }
        else
        {
            Array[++top] = data;
            Console.WriteLine("Array Input : " + data);
        }
    }
    public int pop()
    {
        if (isEmpty())
        {
            Console.WriteLine("배열이 비어있습니다.");
            return 0;
        }
        return Array[top--];
    }
}
class Stack
{
    static void Main(string[] args)
    {
        LLStack llstack = new LLStack();
        int size = 3;
        AStack astack = new AStack(3);
        llstack.push(1);
        llstack.push(2);
        llstack.push(3);
        Console.WriteLine(llstack.pop());
        Console.WriteLine(llstack.pop());
        Console.WriteLine(llstack.pop());
        astack.push(4);
        astack.push(5);
        astack.push(7);
        Console.WriteLine(astack.pop());
        Console.WriteLine(astack.pop());
        Console.WriteLine(astack.pop());
    }
}