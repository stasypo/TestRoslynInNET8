namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA1859: Use concrete types when possible for improved performance
 * Default severity: None
 * Category: Performance
 * Quick fix: ?
 * https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1859
 */
public class CA1859
{
    abstract class A
    {
        public virtual void M()
        {
        }
    }

    sealed class B
    {
    }

    internal class C
    {
        private readonly A _a = new B();

        public void Trigger()
        {
            //this performs a virtual call because _a is defined as an abstract class
            _a.M();
        }
    }
}