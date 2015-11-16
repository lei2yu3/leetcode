/*

Implement the following operations of a stack using queues.

push(x) -- Push element x onto stack.
pop() -- Removes the element on top of the stack.
top() -- Get the top element.
empty() -- Return whether the stack is empty.

Notes:
You must use only standard operations of a queue -- which means only push to back, peek/pop from front, size, and is empty operations are valid. Depending on your language, queue may not be supported natively. 
You may simulate a queue by using a list or deque (double-ended queue), as long as you use only standard operations of a queue.
You may assume that all operations are valid (for example, no pop or top operations will be called on an empty stack).


用栈实现队列

使用一个队列，在每个元素入栈时将队列逆序。于是出栈pop、获取栈顶peek操作就相当于出队列dequeue、获取队列顶peek操作


*/


public class Stack 
{
    Queue<int> stack = new Queue<int>();

    // Push element x onto stack.
    public void Push(int x)
    {
        stack.Enqueue(x);

        for (int i = 0; i < stack.Count - 1; i++)
        {
            stack.Enqueue(stack.Dequeue());
        }
    }

    // Removes the element on top of the stack.
    public void Pop()
    {
        stack.Dequeue();
    }

    // Get the top element.
    public int Top()
    {
        return stack.Peek();
    }

    // Return whether the stack is empty.
    public bool Empty()
    {
        return stack.Count == 0;
    }
}
