namespace Stack.Tests;

public class StackTest
{
    private Stack stack = new();

    [SetUp]
    public void Setup()
        => stack = new Stack();

    [Test]
    public void PopFromEmptyStackShouldThrowException()
        => Assert.Throws<Exception>(stack.Pop);

    [Test]
    public void PushAndTopShouldReturnTheSameElement()
    {
        stack.Push(239);

        Assert.That(stack.Top(), Is.EqualTo(239));
    }
}