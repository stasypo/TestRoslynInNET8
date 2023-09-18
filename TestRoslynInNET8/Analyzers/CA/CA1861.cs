namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA1860: Avoid constant arrays as arguments
 * Default severity: Info
 * Category: Performance
 * Quick fix: available
 */
public class CA1861
{
    // EXPECTED:
    // - Suggestion highlighting on `new[] { "Hello", "world!" }`
    // - Quick fix: available
    string message = string.Join(" ", new[] { "Hello", "world!" });
}