namespace _001
{
    public class Complexity<T>
{
    public T Result { get; }
    public int Steps { get; }

    public Complexity(T result, int steps)
    {
        this.Result = result;
        this.Steps = steps;
    }
}
}