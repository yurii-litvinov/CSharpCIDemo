namespace Stack;

/// <summary>
/// FIFO container.
/// </summary>
public class Stack
{
    private record StackElement(int Value, StackElement? Next = null);

    private StackElement? head;

    public void Push(int value)
        => head = 
            head == null 
                ? new StackElement(value) 
                : new StackElement(value, head);

    public void Pop()
        => head = (head ?? throw new Exception()).Next;

    public int Top()
        => head!.Value;

    public void Clear()
        => head = null;
}
