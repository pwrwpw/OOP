## 과제 내용
- C# 을 이용하여 STACK 구현(배열 & 링크드리스트) 및 테스트 (23.03.22)
## 코드

```csharp
using System;

class Node //노드 클래스
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
        Node newNode = new Node(input); // 추가할 input에 대해 새로운 newNode 생성
        newNode.next = head;            // newNode 다음을 head로 연결
        head = newNode;                 // head를 newNode로 변경
    }
    public void delete()
    {
        head = head.next;               // head를 head.next로 바꿔줌으로써 head를 delete함
    }
    public int get()
    { 
        if (head == null) return -1;    // head가 null일 경우 get할 것이 없으므로 -1 반환
        return head.data;               // 값이 있을경우 head의 data를 가져감
    }
}
class LLStack
{
    LinkedList link = new LinkedList();
    public void push(int input)
    {
        link.add(input);                // linkedlist 에서 구현한 add를 사용하여 input을 추가함
        Console.WriteLine("Linked Input : " + input);
    }
    public int pop()
    {
        int temp = link.get();          // temp에 get한 값을 저장하고
        link.delete();                  // head를 삭제해준 후
        return temp;                    // temp를 반환시킴
    }
}
class AStack
{
    private int top;
    private int size;
    private int[] Array;

    public AStack(int stSize)
    {
        top = -1;                        //top을 -1로 초기설정
        size = stSize;                   //class 안 size 값을 입력값 stSize로 만듬
        Array = new int[size];           // Array 객체 생성
    }
    public Boolean isEmpty()
    {
        return top == -1;                // top이 -1일 경우 추가된 값이 없으므로 비어있음.
    }
    public Boolean isFull()
    {
        return top == size - 1;          // index는 0부터 시작하기에 -1을 해야 배열의 크기와 맞음
    }
    public void push(int data)
    {
        if (isFull())
        {
            Console.WriteLine("배열이 가득찼습니다.");
        }
        else
        {
            Array[++top] = data;           // top에서 1을 추가한 위치에 data를 저장해줌
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
        return Array[top--];                // 먼저 data를 리턴하면서 top에서 1을 
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
```

## 결과

