using System.Diagnostics;

class MyStack1
{
    private List<int> stack;
    private int top;
    private bool isEmpty;

    public MyStack1()
    {
        stack = new List<int>();
        top = -1;
        isEmpty = true;

    }
    public void Push(int x)
    {
        stack.Add(x);
        ++top;
        Console.WriteLine("An element is added to the stack:" + x);
    }
    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("stack is empty");
            return;
        }
        int value = stack[top];
        stack.Remove(value);
        Console.WriteLine("an element has been removed from the stack:" + value);
    }
    public void Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("stack is empty,no top element exist");
            return;
        }
        int value = stack[top - 1];
        Console.WriteLine($" top element is {value}");
    }
    public void IsEmpty()
    {
        if (top == -1)
        {

            Console.WriteLine("stack is empty");
            return;
        }
        isEmpty = false;
        Console.WriteLine("stack is not empty");
    }
    public void StackElements()
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("no element exist");
            return;
        }
        foreach (int x in stack)
        {
            Console.WriteLine("element of stack are:" + x);

        }
    }


}
class Program
{
    static void Main()
    {
        MyStack1 myStack1 = new MyStack1();
        myStack1.Push(10);
        myStack1.Push(20);
        myStack1.Push(30);
        myStack1.Pop();
        myStack1.Peek();
        myStack1.StackElements();
        myStack1.IsEmpty();

    }

}