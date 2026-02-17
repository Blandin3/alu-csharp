using System;

/// <summary>
/// Generic Queue class
/// </summary>
/// <typeparam name="T">Type of elements in the queue</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Returns the type of the Queue
    /// </summary>
    /// <returns>The type T of the Queue</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}