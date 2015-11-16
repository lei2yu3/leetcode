/*

Implement the following operations of a queue using stacks.

push(x) -- Push element x to the back of queue.
pop() -- Removes the element from in front of queue.
peek() -- Get the front element.
empty() -- Return whether the queue is empty.

Notes:
You must use only standard operations of a stack -- which means only push to top, peek/pop from top, size, and is empty operations are valid. Depending on your language, stack may not be supported natively. 
You may simulate a stack by using a list or deque (double-ended queue), as long as you use only standard operations of a stack.
You may assume that all operations are valid (for example, no pop or peek operations will be called on an empty queue).

用栈实现队列

使用两个栈，input用于入队，output用于出队。入队时直接向input栈push。
获取栈顶时如果outpu栈不为空则直接返回output栈顶；
如果outpu栈为空则需要将input中的元素出栈，并将这些元素按照出栈的顺序入栈到output，再返回output栈顶。
出队时，先调用peek（为了将input中的元素导入到output中），然后再从output栈pop。

*/


public class Queue 
{
    Stack<int> input = new Stack<int>();
    Stack<int> output = new Stack<int>();
    
    // Push element x to the back of queue.
    public void Push(int x) 
    {
        input.Push(x);
    }

    // Removes the element from front of queue.
    public void Pop()
    {
        Peek();
        output.Pop();
    }

    // Get the front element.
    public int Peek()
    {
        if (output.Count == 0)
            while (input.Count != 0)
                output.Push(input.Pop());
        return output.Peek();
    }

    // Return whether the queue is empty.
    public bool Empty()
    {
        return input.Count + output.Count == 0;
    }
}
