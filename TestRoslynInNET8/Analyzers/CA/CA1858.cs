namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA1858: Use StartsWith instead of IndexOf
 * Default severity: Info
 * Category: Performance
 * Quick fix: available
 */
public class CA1858
{
    public void TestMethod()
    {
        string a = "string";
        string b = "st";

        // EXPECTED:
        // - Suggestion highlighting on `a.IndexOf(b)`
        // - Quick fix: available
        if (a.IndexOf(b) == 0)
        {
        }
    }
}