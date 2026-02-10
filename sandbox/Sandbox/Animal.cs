public abstract class Animal
{
    public abstract void GetSound();
}

public class Cat : Animal
{
    public override void GetSound()
    {
        Console.WriteLine("A cat goes Meow");
    }
}

public class Dog: Animal
{
    public override void GetSound()
    {
        Console.WriteLine("A dog goes Woof.");
    }
}