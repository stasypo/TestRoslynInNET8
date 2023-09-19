namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA1859: Use concrete types when possible for improved performance
 * Default severity: None
 * Category: Performance
 * Quick fix: no
 */
public class CA1859
{
    public class X
    {
        // Precondition: uncomment dotnet_diagnostic.CA1859.severity = warning in the .editorconfig
        // EXPECTED: warning highlighting on `GetListPrivate`
        private static IList<string> GetListPrivate()
        {
            return Array.Empty<string>();
        }
    }
}