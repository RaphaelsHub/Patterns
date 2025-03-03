namespace Patterns.CreationalPatterns.Prototype;

public interface IPrototype<T>
{
    T Clone();
}