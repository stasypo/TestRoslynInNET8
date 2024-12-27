namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA1861: Avoid constant arrays as arguments
 * Default severity: Info
 * Category: Performance
 * Quick fix: available
 */
public class CA1861
{
    // EXPECTED:
    // - Info highlighting on `new[]`
    // - Quick fix: available
    string message = string.Join(" ", new[] { "Hello", "world!" });
}