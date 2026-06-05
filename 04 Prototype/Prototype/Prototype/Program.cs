namespace Prototype;

public static class IDeepCopyableExtension 
{
    public static T DeepCopy<T>(this IDeepCopyable<T> self) where T : new()
    {
        return self.DeepCopy();
    }
}
public interface IDeepCopyable<T> where T : new()
{
    void CopyTo(T target);

    T DeepCopy()
    {
        T copy = new T();
        CopyTo(copy);
        return copy;
    }
}

public class Point : IDeepCopyable<Point>
{
    public int X, Y;

    public Point()
    {
    }

    public void CopyTo(Point target)
    {
        target.X = X;
        target.Y = Y;
    }
}

public class Line : IDeepCopyable<Line>
{
    public Point Start, End;

    public Line()
    {
    }

    public void CopyTo(Line target)
    {
        target.Start = Start.DeepCopy();
        target.End = End.DeepCopy();
    }

    public Line DeepCopy()
    {
        return ((IDeepCopyable<Line>)this).DeepCopy();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
