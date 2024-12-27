namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA1510: Use ArgumentNullException throw helper
 * Default severity: Info
 * Category: Maintainability
 * Quick fix: available
 */
public class CA1510
{
    public void TestMethod(string param)
    {
        // EXPECTED:
        // - Info highlighting on `if` statement
        // - Quick fix: available
        if (param is null)
        {
            throw new ArgumentNullException(nameof(param));
        }
    }
}