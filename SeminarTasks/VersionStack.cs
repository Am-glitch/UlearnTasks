using System;
using System.Collections.Generic;

public class VersionStack<T>
{
    private Stack<T> currentStack;
    private LinkedList<Stack<T>> history;
    private Dictionary<int, LinkedListNode<Stack<T>>> versionMap;

    public LinkedList<Stack<T>> History { get; } //Свойство для теста

    public VersionStack()
    {
        currentStack = new Stack<T>();
        history = new LinkedList<Stack<T>>();
        versionMap = new Dictionary<int, LinkedListNode<Stack<T>>>();
    }

    public void Push(T item)
    {
        currentStack.Push(item);
        Commit();
    }

    public T Pop()
    {
        var item = currentStack.Pop();
        Commit();
        return item;
    }

    public void Rollback(int version)
    {
        if (!versionMap.ContainsKey(version))
            throw new ArgumentException("Invalid version number.");

        LinkedListNode<Stack<T>> targetNode = versionMap[version];
        currentStack = new Stack<T>(targetNode.Value);
    }

    public void Forget()
    {
        history.Clear();
        versionMap.Clear();
        currentStack.Clear();
    }

    public void Commit()
    {
        history.AddLast(new Stack<T>(currentStack));
        versionMap[history.Count] = history.Last;
    }
}
