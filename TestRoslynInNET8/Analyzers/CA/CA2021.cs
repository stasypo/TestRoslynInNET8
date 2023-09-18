namespace TestRoslynInNET8.Analyzers.CA;

/*
 * CA2021: Do not use OfType<T>() with impossible types
 * Default severity: Warning
 * Category: Reliability
 * Quick fix: no
 */
public class CA2021
{
    public void TestMethod()
    {
        // EXPECTED: warning highlighting on `Enumerable.Range(1, 100).OfType<A>();`
        Enumerable.Range(1, 100).OfType<A>();
    }
}

public class A
{
    
}