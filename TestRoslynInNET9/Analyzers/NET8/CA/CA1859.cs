namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA1859: Use concrete types when possible for improved performance
 * Default severity: Info
 * Category: Performance
 * Quick fix: no
 */
public class CA1859
{
    public class X
    {
        // EXPECTED: info highlighting on `GetListPrivate`
        private static IList<string> GetListPrivate()
        {
            return Array.Empty<string>();
        }
    }
}