namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA1513: Use ObjectDisposedException throw helper
 * Default severity: Info
 * Category: Maintainability
 * Quick fix: available
 */
public class CA1513
{
    public void TestMethod(string param)
    {
        // EXPECTED:
        // - Info highlighting on `if` statement
        // - Quick fix: available
        if (param is null)
        {
            throw new ObjectDisposedException(nameof(param));
        }
    }
}