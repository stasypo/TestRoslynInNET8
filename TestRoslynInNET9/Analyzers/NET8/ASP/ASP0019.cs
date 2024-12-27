namespace TestRoslynInNET8.Analyzers.ASP;

/*
 * ASP0019: Suggest using IHeaderDictionary.Append or the indexer
 * Default severity: Warning
 * Category: Usage
 * Quick fix: available
 */
public class ASP0019
{
    // TODO Add tests for other ASPxxxx inspections when https://youtrack.jetbrains.com/issue/RIDER-93161/Roslyn-analyses-for-ASP.NET-Core-are-not-shown-in-the-rider-editor is fixed
    public void TestMethod()
    {
        var context = new DefaultHttpContext();

        // EXPECTED:
        // - Warning highlighting on ` context.Request.Headers.Add("Accept", "text/html");`
        // - Quick fix: available
        context.Request.Headers.Add("Accept", "text/html"); 
        // Apply codefix using indexer
        context.Request.Headers["Accept"] = "text/html"; 
        // Apply codefix using IHeaderDictionary.Append
        context.Request.Headers.Append("Accept", "text/html"); 
    }
}