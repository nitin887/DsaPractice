using System.Diagnostics.Tracing;
using System.Security.AccessControl;

class MyStack
{
    private int[] stack;
    private int top;
    private int capacity;
    public bool isEmpty = false;
    public bool isFull = true;

    public MyStack(int cap)
    {
        capacity = cap;
        stack = new int[capacity];
        top = -1;



    }
    public void Push(int x)
    {

        if (top >= capacity - 1)
        {
            Console.WriteLine("stack limit exceeded");
            return;
        }


        stack[++top] = x;


        Console.WriteLine($"{x} element is added to the stack");


    }
    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("stack underflow");
            return;

        }
        int x = stack[top--];
        Console.WriteLine($"  top element {x} is deleted");
    }
    public void Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("stack underflow");
            return;
        }
        int x = stack[top];
        Console.WriteLine($"{x} is the top element");
    }
    public void StackElements()
    {
        foreach (int x in stack)
        {
            Console.WriteLine("stack elements are:");
            Console.WriteLine($"{x}");
        }
    }
    public void IsEmpty()
    {
        if (top == -1)
        {
            isEmpty = true;
            Console.WriteLine("Stack is empty  ");
            return;
        }
        isEmpty = false;
        Console.WriteLine("stack is not empty");
    }
    public void IsFull()
    {
        if (top == -1)
        {

            isFull = false;
            Console.WriteLine("stack is not full");
            return;
        }


        isFull = true;
        Console.WriteLine("stack is full");




    }


}
class Program
{
    static void Main()
    {

        MyStack myStack = new MyStack(5);
        myStack.Push(10);
        myStack.Push(10);
        myStack.Push(10);
        myStack.Push(10);
        myStack.Push(10);
        myStack.Push(20);
        myStack.Pop();
        myStack.Peek();
        myStack.StackElements();
        myStack.IsFull();
        myStack.IsEmpty();


    }
}
