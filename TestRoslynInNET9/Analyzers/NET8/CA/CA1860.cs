namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA1860: Avoid using 'Enumerable.Any()' extension method
 * Default severity: Info
 * Category: Performance
 * Quick fix: available
 */
public class CA1860
{
    bool HasElements(string[] strings)
    {
        // EXPECTED:
        // - Suggestion highlighting on `strings.Any()`
        // - Quick fix: available
        return strings.Any();
    }
}